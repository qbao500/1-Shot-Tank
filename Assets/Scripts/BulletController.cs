using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public PlayerController Player { get; set; }

    public int Owner { get; set; }

    [SerializeField] private float bulletSpeed = 10f;
    [SerializeField] private float bulletTurnSpeed = 80f;

    public void Player_ControlBullet(Transform bullet) => StartCoroutine(BulletMaster(bullet));

    private IEnumerator BulletMaster(Transform bullet)
    {
        float elapsed = 0f;

        while (elapsed < 1.8f)
        {
            // Fly forward
            elapsed += Time.deltaTime;
            bullet.position += bullet.forward * bulletSpeed * Time.deltaTime;

            // Control bullet
            bullet.eulerAngles += Vector3.zero.With(y: Player.RotateValue * bulletTurnSpeed * Time.deltaTime);

            // Check if bullet hits sonething. Reset bullet and destroy hit target if yes
            if (Physics.Raycast(bullet.position, bullet.forward, out RaycastHit hit, 0.1f))
            {
                GameObject hitTank = hit.transform.root.gameObject;

                if (!hitTank.CompareTag("Ground"))      // Somehow it touches ground sometimes
                {
                    hitTank.SetActive(false);           // Kill it
                    Player.spawner.Respawn(hitTank);    // Then respawn
                }

                Player.ResetBullet();
                yield break;
            }

            yield return null;
        }

        // If bullet still exist after 1.5 sec, reset
        if (Player.IsBulletActive) Player.ResetBullet();
    }
}
