using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour, InterfaceInput
{
    public Vector2 Move { get; private set; }
    public bool JumpPressed { get; private set; }
    public bool AttackPresed { get; private set; }
    void Start()
    {
        
    }

    // Update is calle
    // d once per frame
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Move = new Vector2(horizontal, vertical);

        JumpPressed = Input.GetButtonDown("Jump");

        AttackPresed = Input.GetMouseButtonDown(0);
    }
}
