using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;
    private UnityEngine.AI.NavMeshAgent agentComponent;
    // Start is called before the first frame update
    void Start()
    {
        agentComponent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {
        agentComponent.destination = target.transform.position;
    }
}
        
