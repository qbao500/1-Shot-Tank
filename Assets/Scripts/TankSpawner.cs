using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [SerializeField] private BoxCollider groundCol;

    private float ySpawnPos = 1.5f;
    private float spawnOffset = 3f;

    public GameObject tankPrefab;
    private PlayerController tank1;
    private PlayerController tank2;

    private void Awake()
    {
        FirstSpawn();        
    }

    private void FirstSpawn()
    {
        tank1 = Instantiate(tankPrefab, Vector3.zero.With(x: MinBound.x + spawnOffset, y: ySpawnPos), Quaternion.Euler(0, 90, 0))
            .GetComponent<PlayerController>();
        tank2 = Instantiate(tankPrefab, Vector3.zero.With(x: MaxBound.x - spawnOffset, y: ySpawnPos), Quaternion.Euler(0, -90, 0))
            .GetComponent<PlayerController>();

        // Assign tags
        tank1.gameObject.tag = "Tank1";
        tank2.gameObject.tag = "Tank2";

        // Connect tanks to spawner
        tank1.spawner = this;
        tank2.spawner = this;
    }

    public void Respawn(GameObject tank)
    {
        if (tank.CompareTag("Bullet")) { return; }  // Safe check

        tank.transform.position = RandomSpawnPos;
        tank.transform.LookAt(Vector3.zero.DirectionTo(groundCol.bounds.center));
        tank.SetActive(true);
    }

    private Vector3 RandomSpawnPos => Vector3.zero.Random3(MinBound, MaxBound).With(y: ySpawnPos);

    private Vector3 MinBound => groundCol.bounds.min;

    private Vector3 MaxBound => groundCol.bounds.max;
}
