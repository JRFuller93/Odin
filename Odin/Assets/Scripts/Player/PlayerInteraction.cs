using UnityEngine;
using System;

public class PlayerInteraction : MonoBehaviour
{
    //TODO: Refactor
    private static Camera m_playerCamera;    

    public static Action PlayerInteracted;

    [SerializeField] private LayerMask m_interactableMask;

    public static Camera PlayerCamera { get { return m_playerCamera; } }

    // Start is called before the first frame update
    void Start()
    {
        m_playerCamera = this.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        DetectInteractable();
    }

    void DetectInteractable()
    {
        Ray ray = m_playerCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if(Physics.Raycast(ray,out hit, Mathf.Infinity, m_interactableMask))
        {
            if(Input.GetMouseButtonUp(0))
            {
                Debug.Log("Hit");

                Interactable interactable = hit.transform.GetComponent<Interactable>();

                interactable?.OnInteract();
               
                this.enabled = false;
            }
        }
    }
}
