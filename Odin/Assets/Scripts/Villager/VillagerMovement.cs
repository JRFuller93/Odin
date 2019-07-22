using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerMovement : VillagerBehaviour
{

    #region UnityMethods
    // Start is called before the first frame update
    void Start()
    {
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        DetectMovementPostion();
    }

    #endregion

    public void InitMovement()
    {
        this.enabled = true;
    }

    private void DetectMovementPostion()
    {
        Ray ray = PlayerInteraction.PlayerCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hit.collider.CompareTag("Ground"))
                {
                    m_villagerView.NavAgent.destination = hit.point;
                }
            }           
        }
    }
}
