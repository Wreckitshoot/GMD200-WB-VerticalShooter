using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_respawn : MonoBehaviour
{
    public Score score;
    [SerializeField] int PointValue;
    [SerializeField] GameObject point_prefab;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            score.score += PointValue;
            EndscreenScore.setScore(PointValue);
            Instantiate(point_prefab,transform.position,transform.rotation);
            other.gameObject.GetComponent<Enemy>().Respawn();
        }
    }

}
