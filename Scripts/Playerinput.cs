using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerinput : MonoBehaviour, Iinput
{
    public Action<Vector2> OnMovementInput { get; set; }
    public Action<Vector3> OnMovementDirectionInput { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    private Action<Vector3> onMovementDirectionInput1;

    public Action<Vector3> GetOnMovementDirectionInput1()
    {
        return onMovementDirectionInput1;
    }

    public void SetOnMovementDirectionInput1(Action<Vector3> value)
    {
        onMovementDirectionInput1 = value;
    }

    private Action<Vector2> onMovementDirectionInput;

    public Action<Vector2> GetOnMovementDirectionInput()
    {
        return onMovementDirectionInput;
    }

    public void SetOnMovementDirectionInput(Action<Vector2> value)
    {
        onMovementDirectionInput = value;
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        GetMovementInput();
        GetMovementDirection();
    }

    private void GetMovementDirection()
    {
        throw new NotImplementedException();
        var cameraForwardDirection = Camera.main.transform.forward;
        Debug.DrawRay(Camera.main.transform.position, cameraForwardDirection * 10, Color.red);
        var directiontoMoveIn = Vector3.Scale(cameraForwardDirection, (Vector3.right + Vector3.forward));
        Debug.DrawRay(Camera.main.transform.position, directiontoMoveIn * 10, Color.blue);

        GetOnMovementDirectionInput()?.Invoke(directiontoMoveIn);
    }

    private void GetMovementInput()
    {
        throw new NotImplementedException();
        Vector2 input = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        OnMovementInput?.Invoke(input);
    }
}
