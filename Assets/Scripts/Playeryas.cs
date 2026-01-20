using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playeryas : MonoBehaviour
{
    [SerializeField] private int _playerspeed = 3;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private float _groundCheckRadius = 0.2f;
    [SerializeField] private LayerMask _groundLayer;
    
    public Coin cm; 
    

    void Start()
    {
         _rigidbody = GetComponent<Rigidbody2D>();
         GameController.Instance.gameStarted = true;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, 4.0f);
          
        }
        
    }
    private bool IsGrounded()
    {
        if (_groundCheck == null)
            {return false;
            }
            return Physics2D.OverlapCircle(_groundCheck.position, _groundCheckRadius, _groundLayer);
            
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            GameController.Instance.score++;
            GameController.Instance.UpdateScoreUI();
            Destroy(other.gameObject);
    }
        
    }
}
