using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private Text P1Score;
    [SerializeField] private Text P2Score;

    private void Start() => TankManager.SetScoreUI += SetScoreText;

    private void SetScoreText(int p1, int p2)
    {
        P1Score.text = p1.ToString();
        P2Score.text = p2.ToString();
    }
}
