using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerActionsUI : MonoBehaviour
{
    [SerializeField] private GameObject moveActionObj;

    // Start is called before the first frame update
    void Start()
    {
        PlayerInteraction.PlayerInteracted += EnableActionUI;

        DisableActionUI();
    }

    void EnableActionUI()
    {
        moveActionObj.SetActive(true);
    }

    void DisableActionUI()
    {
        moveActionObj.SetActive(false);
    }

    #region Actions

    public void InitiateMoveAction()
    {

    }

    #endregion

}
