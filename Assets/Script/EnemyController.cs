using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public StateSO currentState;
    public Transform player;
    public float speed;
    public float chaseRange;
    public float attackRange;

    void Start()
    {
        if(currentState !=null)
        {
        currentState.Enter(this);
        }
    }
    void Update()
    {
        if(currentState !=null)
        {
            Debug.Log("State: " + currentState.name);
            currentState.Execute(this);
        }
    }
    
    public void ChangeState(StateSO newState)
{
    if(currentState !=null)
    {
       currentState.Exit(this);
    }

    currentState = newState;

    if(currentState !=null)
    {
       currentState.Enter(this);
    }
}
   public float DistanceToPlayer()
{
    if(player == null) return Mathf.Infinity;
    return Vector2.Distance(transform.position, player.position);
}

}


