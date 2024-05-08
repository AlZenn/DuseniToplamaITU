using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectorSc : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("good") ||
            other.gameObject.CompareTag("bad") )
        {
            Destroy(other.gameObject);
        }
    }
}
