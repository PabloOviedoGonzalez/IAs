using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class StateMachine : MonoBehaviour
{
    public State initialState; //estado inicial
    private State _currentState; //estado en el q se encuentra
    // Start is called before the first frame update
    void Start()
    {
        ChangeState(initialState);
    }

    // Update is called once per frame
    void Update()
    {
        State nextState = _currentState.Run(gameObject);

        if (nextState != null)
        {
           ChangeState(nextState);
        }
    }

    void ChangeState(State newState) //cambia el estado a un nuevo estado
    {
        _currentState = newState;
        _currentState.Init(gameObject);
    }
}
