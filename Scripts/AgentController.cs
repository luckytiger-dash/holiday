using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{
    private const string V1 = "Movement input";
    
    Iinput input;
    AgentMovement movement;

    // Start is called before the first frame update
    private void OnEnable()
    {
        input = GetComponent<Iinput>();
        movement = GetComponent<AgentMovement>();
        input.OnMovementInput += movement.HandleMovement;
        input.OnMovementDirectionInput += movement.HandleMovementDirection;
    }
    private void OnDisable()
    {
        input.OnMovementInput += movement.HandleMovement;
        input.OnMovementDirectionInput += movement.HandleMovementDirection;
    }
}
