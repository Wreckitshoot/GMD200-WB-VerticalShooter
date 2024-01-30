using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DATASAVER : MonoBehaviour
{
    // Start() and Update() methods deleted - we don't need them right now

    public static DATASAVER Instance;

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
