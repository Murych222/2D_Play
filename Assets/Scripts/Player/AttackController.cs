using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    private InterfaceInput _input;
    private IWeapon _weapon; 


    void Start()
    {
        _input = GetComponent<InterfaceInput>();
        _weapon = GetComponent<IWeapon>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_input.AttackPresed)
        {
            _weapon.Use();
        }
    }
}
