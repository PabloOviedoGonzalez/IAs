using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class Action : ScriptableObject //case abstracta de la accion
{
    public abstract bool Check(GameObject owner); //dueño de la accion: owner

    public virtual void DrawGizmo(GameObject owner)
    {

    }

    
}
