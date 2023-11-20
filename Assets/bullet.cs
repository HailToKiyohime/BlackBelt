using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    float maxLifeTime = 3;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        maxLifeTime = maxLifeTime - Time.deltaTime;
        if (maxLifeTime<0)
        {
            Destroy(gameObject);
        }
    }
}
