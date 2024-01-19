using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pewpew : MonoBehaviour
{
    public GameObject PewPewPrefab;
    public float PewSpeed = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //shoot pew
            GameObject Pew = Instantiate(PewPewPrefab,transform.position, Quaternion.identity);
            Rigidbody2D PewRB = Pew.GetComponent<Rigidbody2D>();
            PewRB.velocity = transform.up * PewSpeed;
        }
    }
}
