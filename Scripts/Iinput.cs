using System;
using UnityEngine;

public interface Iinput
{
    Action<Vector2> GetOnMovementDirectionInput();
    void SetOnMovementDirectionInput(Action<Vector2> value);

    Action<Vector2> OnMovementInput { get; set; }
    Action<Vector3> OnMovementDirectionInput { get; set; }
    Action<Vector3> GetOnMovementDirectionInput1();
    void SetOnMovementDirectionInput1(Action<Vector3> value);
}