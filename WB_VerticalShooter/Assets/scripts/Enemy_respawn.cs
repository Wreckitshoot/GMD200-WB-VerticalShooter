using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_respawn : MonoBehaviour
{
    [SerializeField] int PointValue;
    [SerializeField] GameObject point_prefab;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            
            //GetComponent<Score>().update(PointValue);
            Instantiate(point_prefab,transform.position,transform.rotation);
            other.gameObject.GetComponent<Enemy>().Respawn();
        }
    }

}
