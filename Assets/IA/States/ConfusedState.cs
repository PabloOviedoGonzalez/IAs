using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) Confused", menuName = "ScriptableObjects/States/ConfusedState")] //crea una ruta en el menu de unity para crear un ScriptableObject que en nustro caso es una clase

public class ConfusedState : State
{
    
    public override void Init(GameObject owner) //sobreescribimos el estado inicial como si fuese el start del agente
    {
        base.Init(owner); //estado inicial del padre
    }

    public override State Run(GameObject owner) //sobreescribimos el run del padre
    {

        owner.transform.Rotate(Vector3.up, 20);
        return base.Run(owner);
    }
}
