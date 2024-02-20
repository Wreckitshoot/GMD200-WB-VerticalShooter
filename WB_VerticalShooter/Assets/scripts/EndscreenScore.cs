using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EndscreenScore 
{
    // Start is called before the first frame update
    public static int score = 0;

    public static void setScore(int points)
    {
        score += points; 
    }
    public static int getScore() { return score;}

    public static void resetScore() { score = 0; }
}
