using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;

public class SpawnerSc : MonoBehaviour
{
    public GameObject[] drops;
    public float x1, x2;
    
    void Start()
    {
        x1 = transform.position.x - GetComponent<BoxCollider2D>().bounds.size.x / 2f;
        x2 = transform.position.x + GetComponent<BoxCollider2D>().bounds.size.x / 2f;

        StartCoroutine(Clone(2f)); // fonskiyon adı ve kaç sn de çağırılacağı
    }

    IEnumerator Clone(float time)
    {
        yield return new WaitForSeconds(time);
        Instantiate(drops[Random.Range(0, drops.Length)],
            new Vector3(Random.Range(x1,x2),transform.position.y,transform.position.z),
            Quaternion.identity);
        
        StartCoroutine(Clone(Random.Range(1f,2f))); 
    }
}
