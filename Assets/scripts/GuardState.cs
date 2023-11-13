using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) Guard", menuName = "ScriptableObjects/States/GuardState")] //crea una ruta en el menu de unity para crear un ScriptableObject que en nustro caso es una clase

public class GuardState : State
{
    public Vector3 guardPoint; //el punto donde va a hacer guardia
    

    public override void Init(GameObject owner) //sobreescribimos el estado inicial como si fuese el start del agente
    {
       base.Init(owner); //estado inicial del padre
    }
    public override State Run(GameObject owner) //sobreescribimos el run del padre
    {
        owner.GetComponent<NavMeshAgent>().SetDestination(guardPoint); //le damos un destino al agente

        return base.Run(owner);
    }
}
