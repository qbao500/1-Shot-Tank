using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [HideInInspector] public Tank tank;

    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private float bulletTurnSpeed = 80f;
    [SerializeField] private float activeTime = 1.5f;

    public static event Action<GameObject, bool> HitPlayer = delegate { };

    // This is called when player shoot
    public void Player_ControlBullet(Transform bullet) => StartCoroutine(BulletMaster(bullet));

    // Actual function that controls bullet
    private IEnumerator BulletMaster(Transform bullet)
    {
        float elapsed = 0f;

        while (elapsed < activeTime)
        {
            // Fly forward
            elapsed += Time.deltaTime;
            bullet.position += bullet.forward * bulletSpeed * Time.deltaTime;

            // Control bullet
            bullet.eulerAngles += Vector3.zero.With(y: tank.Input.RotateValue * bulletTurnSpeed * Time.deltaTime);

            yield return null;
        }

        // If bullet still exist after aliveTime, reset
        if (tank.IsBulletActive()) tank.ResetBullet();
    }

    // Check if hit other tank
    private void OnTriggerEnter(Collider other)
    {
        GameObject hitTank = other.transform.root.gameObject;

        // Return if null or hit self/ground/bullet
        if (!hitTank || hitTank == tank.gameObject) return;
        if (hitTank.CompareTag("Ground") || hitTank.CompareTag("Bullet")) return;

        HitPlayer(hitTank, false);

        tank.ResetBullet();
    }
}
