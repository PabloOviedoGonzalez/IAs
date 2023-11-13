using UnityEngine;
using UnityEngine.AI;

[System.Serializable]
public struct ActionParameter
{
    public Action action;
    public bool actionValue;
}

[System.Serializable]
public struct StateParametre
{
    public ActionParameter[] actionParameter;
    [Tooltip("Only one action must be true or very action must be true")]
    public bool or;
    public State nextState;

}

public abstract class State : ScriptableObject //esto va a devolver el siguiente estado
{
    public StateParametre[] parametres;
    protected NavMeshAgent navMeshAgent;

    public virtual void Init(GameObject owner)  //le da el estado inicial al agente
    {
        navMeshAgent = owner.GetComponent<NavMeshAgent>();
    }
    public virtual State Run(GameObject owner)  //recorre el array de estados q hays puesto, es como el update
    {
        foreach(StateParametre actualParameter in parametres) //lo recorre
        {
            bool andResult = true;
            foreach(ActionParameter actualActionParameter in actualParameter.actionParameter)
            {
                bool currentActionCheck = actualActionParameter.action.Check(owner) == actualActionParameter.actionValue;
                andResult &= currentActionCheck; // andResult = andResult && currenteActionCheck; es lo mismo

                if(actualParameter.or && currentActionCheck)  //si el or esta marcado como true significa q minimo se tiene q cumplir una accion, asiq si el check es true significa que ya está
                {
                    return actualParameter.nextState;
                }
            }

            if(andResult) //&&
            {
                return actualParameter.nextState;
            }
        }
        return null;
    }
}
