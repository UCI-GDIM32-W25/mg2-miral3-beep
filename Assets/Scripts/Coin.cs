using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 3f;
    

    void Update()
    {
        transform.position += Vector3.left * _moveSpeed * Time.deltaTime;
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }


}

