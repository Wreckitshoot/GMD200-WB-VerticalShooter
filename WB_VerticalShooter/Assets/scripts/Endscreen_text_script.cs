using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Endscreen_text_script : MonoBehaviour
{
    public TextMeshProUGUI scoreboard;
    public int score = 0;
    // Start is called before the first frame update

    void Update()
    {
        scoreboard.text = "Game Over\r\nTotal Score: " + EndscreenScore.getScore() + "\r\nPress R to restart.: ";
    }
}
