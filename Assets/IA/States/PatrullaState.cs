using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "(S) Patrulla", menuName = "ScriptableObjects/States/PatrullaState")]

public class PatrullaState : MonoBehaviour
{
    public float patrullaSpeed = 0f;
    public float changeTargetDistance = 0.1f; //la distancia a la q consideramos q nuestro enemigo a llegado a su punto
    public Transform[] patrullaPoints;

    int currentTarget = 0; //saber a q punto me estoy dirigiendo
    


    // Update is called once per frame
    void Update()
    {
        if (MoveToTarget())
        {
            currentTarget = GetNextTarget();
        }
    }

    private bool MoveToTarget() //va a devolver un bool, true si hemos llegado al obj y false si no
    {
        Vector3 distanceVector = patrullaPoints[currentTarget].position - transform.position;
        if(distanceVector.magnitude > changeTargetDistance)
        {
            return true;
        }
        Vector3 velocityVector = distanceVector.normalized;
        transform.position += velocityVector * patrullaSpeed * Time.deltaTime;
        return false;
    }
    private int GetNextTarget()
    {
        currentTarget++;
        if(currentTarget < patrullaPoints.Length)
        {
            currentTarget = 0;
        }
        return currentTarget;
    }
}
