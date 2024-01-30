using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreboard;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        
        
    }
    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        i++;
        scoreboard.text = i.ToString();
    }
    public void update(int points)
    {
        i += points;

        scoreboard.text = "Score: " + i.ToString();
    }
}
