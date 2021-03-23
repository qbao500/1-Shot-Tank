using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScoreManager", menuName = "ScriptableObjects/ScoreManager")]
public class ScoreManagerSO : ScriptableObject
{
    private int player1Score = 0;
    private int player2Score = 0;

    private void OnEnable() => ResetScores();

    public void ResetScores()
    {
        player1Score = 0;
        player2Score = 0;
    }

    public void AddScore1() => player1Score++;

    public void AddScore2() => player2Score++;

    public void MinusScore1()
    {
        if (player1Score > 0) { player1Score--; }
    }

    public void MinusScore2()
    {
        if (player2Score > 0) { player2Score--; }
    }
}
