using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankManager : MonoBehaviour
{
    // Ground
    [SerializeField] private BoxCollider groundCol;

    // Spawn variables
    private float ySpawnPos = 1.5f;
    private float spawnOffset = 2f;
    private float spawnDistance = 10f;

    // Tanks
    public GameObject tankPrefab;
    private PlayerController tank1;
    private PlayerController tank2;

    // Score
    [SerializeField] private ScoreManagerSO scoreManager;

    // Events
    public static event Action<int, int> SetScoreUI = delegate { };

    private void Awake()
    {
        Border.PlayerFall += TankDied;
        BulletController.HitPlayer += TankDied;

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

    public void TankDied(GameObject deadTank, bool isFalled = false)
    {
        // Kill it and add score
        deadTank.SetActive(false);
        scoreManager.CalculateScore(deadTank, isFalled);
        SetScoreUI(scoreManager.P1Score, scoreManager.P2Score);

        // If dead tank is NOT tank 1, then tank 1 is alive, otherwise tank 2 is alive
        GameObject aliveTank = !deadTank.CompareTag("Tank1") ? tank1.gameObject : tank2.gameObject;
        Respawn(deadTank, aliveTank);
    }

    private void Respawn(GameObject deadTank, GameObject aliveTank)
    {
        deadTank.transform.position = GetRandomSpawnPos(aliveTank);
        deadTank.transform.LookAt(transform.position.DirectionTo(groundCol.bounds.center));
        deadTank.transform.eulerAngles = deadTank.transform.eulerAngles.With(x: 0);
        deadTank.SetActive(true);
    }

    private Vector3 GetRandomSpawnPos(GameObject aliveTank)
    {
        Vector3 randomPos = Vector3.zero.Random3(MinBound, MaxBound).With(y: ySpawnPos);
        if (Vector3.Distance(randomPos, aliveTank.transform.position) >= spawnDistance)
        {
            return randomPos;
        }
        else
        {
            return GetRandomSpawnPos(aliveTank);
        }
    }

    private Vector3 MinBound => groundCol.bounds.min.WithOffset(spawnOffset);

    private Vector3 MaxBound => groundCol.bounds.max.WithOffset(-spawnOffset);
}
