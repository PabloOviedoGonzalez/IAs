using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(fileName = "(S) Huir", menuName = "ScriptableObjects/States/HuirState")]

public class HuidaState : State
{
    private Vector3 rndPos;
    public override void Init(GameObject owner) //sobreescribimos el estado inicial como si fuese el start del agente
    {
        base.Init(owner); //estado inicial del padre
        rndPos = new Vector3(Random.Range(owner.transform.position.x + 200, owner.transform.position.x - 200), owner.transform.position.y, Random.Range(owner.transform.position.z + 200, owner.transform.position.z - 200));
    }
    public override State Run(GameObject owner) //sobreescribimos el run del padre
    {
        
        navMeshAgent.SetDestination(rndPos);
        if(navMeshAgent.remainingDistance < 2)
        {
            rndPos = new Vector3(Random.Range(owner.transform.position.x + 200, owner.transform.position.x - 200), owner.transform.position.y, Random.Range(owner.transform.position.z + 200, owner.transform.position.z - 200));

        }
        return base.Run(owner);
    }
}
