using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface InterfaceInput
{
    Vector2 Move {  get; }
    public bool JumpPressed { get; }

    public bool AttackPresed { get; }


}
