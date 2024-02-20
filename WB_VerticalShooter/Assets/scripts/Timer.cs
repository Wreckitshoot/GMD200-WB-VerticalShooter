using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI timer;
    [SerializeField] float targetTime = 60.0f;

        void Update()
        {

            targetTime -= Time.deltaTime;
            timer.text = targetTime.ToString();
            if (targetTime <= 0.0f)
            {
                timerEnded();
            }

        }

        void timerEnded()
        {
        //new scene
            SceneManager.LoadScene("End_Screen");
        }


    
}
