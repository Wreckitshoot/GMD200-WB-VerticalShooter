using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreboard;
    public int score = 0;
    // Start is called before the first frame update
    
    void Update()
    {
        scoreboard.text = "Score: " + EndscreenScore.getScore();
    }
}
