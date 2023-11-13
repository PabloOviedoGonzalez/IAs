using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "(A) NoHear", menuName = "ScriptableObjects/Actions/NoHearActions")] //crea una ruta en el menu de unity para crear un ScriptableObject que en nustro caso es una clase

public class NoHearAction : Action
{
    public float noHearRadius;
    public override bool Check(GameObject owner)
    {
        RaycastHit[] hits = Physics.SphereCastAll(owner.transform.position, noHearRadius, Vector3.up);


        foreach (RaycastHit hit in hits)  //comprobamos toda el area de la esfera 
        {
            if (!hit.collider.GetComponent<PlayerMovement>()) //si "golpea" en algun punto al player
            {
                return true;
            }
        }
        return false;
    }
}
