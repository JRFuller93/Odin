using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VillagerView : Interactable
{
    private NavMeshAgent m_navMeshAgent;

    //Behaviours
    private VillagerMovement m_villagerMovement;

    //Public
    public NavMeshAgent NavAgent { get { return m_navMeshAgent; } }

    // Start is called before the first frame update
    void Awake()
    {
        m_navMeshAgent = this.GetComponent<NavMeshAgent>();
        m_villagerMovement = this.GetComponent<VillagerMovement>();
    }

    public override void OnInteract()
    {
        base.OnInteract();
        m_villagerMovement.InitMovement();
    }

}
