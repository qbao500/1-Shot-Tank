using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private PlayerControls playerControl;
    private Rigidbody rb;
    [HideInInspector] public TankSpawner spawner;

    // Speed
    [SerializeField] private float moveSpeed = 3f;
    [SerializeField] private float turnSpeed = 70f;
    [SerializeField] private float teleSpeed = 8f;
    [SerializeField] private float recoilPower = 2f;

    // Input values
    public float RotateValue { get; private set; }
    private float forwardValue;

    // Shoot properties
    [SerializeField] private Transform shootPoint;
    [SerializeField] private GameObject bullet;

    // Booleans
    private bool canShoot = true;
    private bool isTeleporting = false;

    // Events
    public event Action<Transform> ControlBullet = delegate { };

    private void Awake()
    {
        playerControl = new PlayerControls();
        
        rb = GetComponent<Rigidbody>();
        rb.centerOfMass = Vector3.zero;

        InstantiateBullet();
    }

    private void OnEnable()
    {
        playerControl.Enable();
    }

    private void Start()
    {
        GetActionMap();        
    }

    private void OnDisable()
    {
        playerControl.Disable();
      
        if (IsBulletActive) { ResetBullet(); }  // If dead, remove bullet if exist
    }

    private void FixedUpdate()
    {
        RotatePlayer();
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        if (isTeleporting) { return; }  // Can't move when teleport

        transform.position += (transform.forward * forwardValue) * moveSpeed * Time.deltaTime;
    }

    private void RotatePlayer() => transform.eulerAngles += Vector3.zero.With(y: RotateValue * turnSpeed * Time.deltaTime);

    private void Shoot()
    {      
        rb.AddForce(-transform.forward * recoilPower, ForceMode.Impulse);   // Recoil effect

        // Shoot bullet
        canShoot = false;       
        bullet.transform.position = shootPoint.position;
        bullet.transform.rotation = transform.rotation;
        bullet.gameObject.SetActive(true);
        
        // Move bullet
        ControlBullet(bullet.transform);       
    }

    private IEnumerator Teleport()
    {
        // Decrease turn speed when teleporting
        float newTurn = turnSpeed;
        turnSpeed = newTurn / 4;

        // Teleport to bullet position
        Vector3 destination = bullet.transform.position;
        isTeleporting = true;

        while (Vector3.Distance(transform.position, destination) > 0f)
        {
            transform.position = Vector3.MoveTowards(transform.position, destination, teleSpeed * Time.deltaTime);
            yield return null;
        }

        turnSpeed = newTurn;
    }

    public void ResetBullet()
    {
        bullet.SetActive(false);
        canShoot = true;
        isTeleporting = false;
    }

    public bool IsBulletActive => bullet.activeInHierarchy;

    private void GetActionMap()
    {
        if (CompareTag("Tank1"))
        {
            playerControl.Tank1.Forward.performed += ctx => forwardValue = ctx.ReadValue<float>();
            playerControl.Tank1.Rotate.performed += ctx => RotateValue = ctx.ReadValue<float>();
            playerControl.Tank1.Shoot.performed += ctx => { if (canShoot && !isTeleporting) Shoot(); };
            playerControl.Tank1.Teleport.performed += ctx => { if (IsBulletActive && !isTeleporting) StartCoroutine(nameof(Teleport)); };
        }
        else if (CompareTag("Tank2"))
        {
            playerControl.Tank2.Forward.performed += ctx => forwardValue = ctx.ReadValue<float>();
            playerControl.Tank2.Rotate.performed += ctx => RotateValue = ctx.ReadValue<float>();
            playerControl.Tank2.Shoot.performed += ctx => { if (canShoot && !isTeleporting) Shoot(); };
            playerControl.Tank2.Teleport.performed += ctx => { if (IsBulletActive && !isTeleporting) StartCoroutine(nameof(Teleport)); };
        }
    }

    private void InstantiateBullet()
    {
        bullet = Instantiate(bullet);
        var bulletControl = bullet.GetComponent<BulletController>();
        bulletControl.Player = this;
        ControlBullet += bulletControl.Player_ControlBullet;
        bullet.SetActive(false);       
    }
}
