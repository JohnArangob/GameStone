using UnityEngine;
using UnityEngine.AI;

[CreateAssetMenu(menuName = "Create EnemyProPlayer", fileName = "Enemigo", order = 0)]
public class EnemyProPlayer : EnemyCharacter

{

    private NavMeshAgent _agent;


    public void Initialize(NavMeshAgent agent)
    {
        _agent = agent;
    }
    public override void EstadoIdle()
    {
        base.EstadoIdle();
        _agent.SetDestination(_agent.transform.position);
        UnityEngine.Debug.Log("Kieto");
    }
    public override void EstadoSeguir()
    {
        base.EstadoSeguir();
        _agent.SetDestination(target.transform.position);
        //UnityEngine.Debug.Log("siguiendo endo");
    }
    public override void EstadoAtacar()
    {
        base.EstadoAtacar();
        _agent.SetDestination(_agent.transform.position);
        _agent.transform.LookAt(target,Vector3.up);
    }
    public override void EstadoMuerto()
    {
        base.EstadoMuerto();
        _agent.enabled = false;
        //UnityEngine.Debug.Log("muriendo endo");
    }
    
}
