using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) Chase", menuName = "ScriptableObjects/States/ChaseState")]

public class ChaseScript : State
{
    private GameObject target;

    public override void Init(GameObject owner) //sobreescribimos el estado incial y se lo ponemos como si fuese el start del agente
    {
        base.Init(owner); //estado incial del padre
        target = FindAnyObjectByType<PlayerMovement>().gameObject; //le decimos q siga al jugador
    }
    public override State Run(GameObject owner) //sobreescribimos el run del padre
    {
        Vector3 targetPos = target.transform.position;

        navMeshAgent.SetDestination(targetPos); //le damos la posicion q tiene q tener el agente

        return base.Run(owner);
    }
}
