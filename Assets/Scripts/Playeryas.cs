using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeryas : MonoBehaviour
{
    [SerializeField] private int _playerspeed = 3;
    [SerializeField] private Rigidbody2D _rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
         _rigidbody = GetComponent<Rigidbody2D>();
         
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 4.0f);
          
        }
        
    }
}
