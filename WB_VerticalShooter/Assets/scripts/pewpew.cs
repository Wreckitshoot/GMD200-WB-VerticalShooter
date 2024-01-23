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
        StartCoroutine( Co_Shootroutine());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //shoot pew
            shoot();
        }
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = transform.position.z;
        transform.up = mouseWorldPos - transform.position;
    }
    private void shoot()
    {
        //shoot pew
        GameObject Pew = Instantiate(PewPewPrefab, transform.position+ transform.up, transform.rotation);
        Rigidbody2D PewRB = Pew.GetComponent<Rigidbody2D>();
        PewRB.velocity = transform.up * PewSpeed;
        Destroy(PewRB.gameObject, 2.0f);
    }
    IEnumerator Co_Shootroutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(2.0f);
            shoot();
        }
    }
}
