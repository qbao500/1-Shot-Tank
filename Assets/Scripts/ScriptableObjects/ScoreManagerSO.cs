using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreManager", menuName = "ScriptableObjects/ScoreManager")]
public class ScoreManagerSO : ScriptableObject
{
    public int P1Score { get; private set; }
    public int P2Score { get; private set; }

    private void OnEnable() => ResetScores();

    public void ResetScores() => P1Score = P2Score = 0;

    public void CalculateScore(GameObject deadTank, bool isFalled = false)
    {
        if (deadTank.CompareTag("Tank1"))
        {
            if (isFalled) MinusScore1();
            else AddScore2();
        }
        else
        {
            if (isFalled) MinusScore2();
            else AddScore1();
        }
    }

    public void AddScore1() => P1Score++;

    public void AddScore2() => P2Score++;

    public void MinusScore1()
    {
        if (P1Score > 0) { P1Score--; }
    }

    public void MinusScore2()
    {
        if (P2Score > 0) { P2Score--; }
    }
}
