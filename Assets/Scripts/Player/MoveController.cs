using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 6f;
    [SerializeField] private float _jumpForce = 1f;
    [SerializeField] private bool _groundIndicator;




    [SerializeField] private Rigidbody2D rb;
    private InterfaceInput _input;

    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _input = GetComponent<InterfaceInput>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(_input.Move.x * _moveSpeed * Time.deltaTime, 0,0);

       
    }

    private void Update()
    {
        if(_input.JumpPressed && _groundIndicator)
        {
            
            rb.AddForce(Vector2.up * _jumpForce , ForceMode2D.Impulse);

        }
             
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dirt"))
        {
            _groundIndicator = true;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Dirt"))
        {
            _groundIndicator = false;
        }
    }
}
