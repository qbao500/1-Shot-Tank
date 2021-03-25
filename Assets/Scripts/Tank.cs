using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    public PlayerInput Input { get; private set; }
    private Rigidbody rb;

    // Speed
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float turnSpeed = 70f;
    [SerializeField] private float teleSpeed = 8f;
    [SerializeField] private float recoilPower = 2f;

    // Shoot properties
    [SerializeField] private Transform shootPoint;
    [SerializeField] private GameObject bullet;

    public event Action<Transform> ControlBullet = delegate { };

    private void Awake()
    {
        Input = GetComponent<PlayerInput>();

        SetupRigidBody();
        InstantiateBullet();

        Input.ShootPressed += TankShoot;
        Input.TeleportPressed += TankTeleport;
    }

    private void FixedUpdate()
    {
        RotatePlayer();
        PlayerMovement();
    }

    private void OnDisable()
    {
        if (IsBulletActive()) { ResetBullet(); }  // If dead, remove bullet if exist
    }

    private void PlayerMovement()
    {
        if (Input.IsTeleporting) { return; }  // Can't move when teleport

        transform.position += (transform.forward * Input.ForwardValue) * moveSpeed * Time.deltaTime;
    }

    private void RotatePlayer() => transform.eulerAngles += Vector3.zero.With(y: Input.RotateValue * turnSpeed * Time.deltaTime);

    private void TankShoot()
    {
        rb.AddForce(-transform.forward * recoilPower, ForceMode.Impulse);   // Recoil effect

        // Shoot bullet
        bullet.transform.position = shootPoint.position;
        bullet.transform.rotation = transform.rotation;
        bullet.gameObject.SetActive(true);

        // Move bullet
        ControlBullet(bullet.transform);
    }

    private void TankTeleport()
    {
        if (!IsBulletActive()) return; // Return if no bullet exists

        StartCoroutine(nameof(Teleporting));
    }

    private IEnumerator Teleporting()
    {
        Input.StartTeleport();

        // Decrease turn speed when teleporting
        float newTurn = turnSpeed;
        turnSpeed = newTurn / 3;

        // Teleport to bullet position
        Vector3 destination = bullet.transform.position.With(y: transform.position.y);
        while (Vector3.Distance(transform.position, destination) > 0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, teleSpeed * Time.deltaTime);
            yield return null;
        }

        turnSpeed = newTurn;    // Get back normal turn speed
        Input.DoneTeleport();
    }

    private void SetupRigidBody()
    {
        rb = GetComponent<Rigidbody>();
        rb.angularVelocity = Vector3.zero;
        rb.centerOfMass = Vector3.zero;
        rb.freezeRotation = true;
    }

    private void InstantiateBullet()
    {
        bullet = Instantiate(bullet);
        var bulletControl = bullet.GetComponent<BulletController>();
        bulletControl.tank = this;
        ControlBullet += bulletControl.Player_ControlBullet;
        bullet.SetActive(false);
    }

    public void ResetBullet()
    {
        bullet.SetActive(false);
        Input.ResetShooting();
    }

    public bool IsBulletActive()
    {
        if (bullet) return bullet.activeInHierarchy;
        else return false;
    }
}
