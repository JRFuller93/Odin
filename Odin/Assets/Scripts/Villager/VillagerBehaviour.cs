using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerBehaviour : MonoBehaviour
{
    protected VillagerView m_villagerView;

    private void Awake()
    {
        m_villagerView = this.GetComponent<VillagerView>();
    }
}
