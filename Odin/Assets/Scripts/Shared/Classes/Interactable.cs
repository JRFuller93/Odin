using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.layer = LayerMask.NameToLayer("Interactable");
    }

    public virtual void OnInteract()
    {

    }
}
