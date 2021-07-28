using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LoseConditionChecker : MonoBehaviour
{
    int IndexOfCheckedWeb = 0;
    GameObject[] Webs;
    [SerializeField] GameObject[] MovementScriptHolders;
    [SerializeField] UnityEvent OnLoss;

    void Start()
    {
        Webs = GetComponent<IControlledObjects>().GetControlledObjects();
        YAxisMover webMover = GetComponent<YAxisMover>();
        webMover.OnWrongMove += KillMovement;
    }

    void Update()
    {
        bool webIsOnLevelWithSpider = Webs[IndexOfCheckedWeb].transform.position.y < -3.5;
        bool webIsToTheSideOfSpider = Webs[IndexOfCheckedWeb].transform.position.x != 0;
        if (webIsOnLevelWithSpider)
        {
            if (webIsToTheSideOfSpider)
            {
                KillMovement();
                OnLoss?.Invoke();
            }
            IndexOfCheckedWeb = ++IndexOfCheckedWeb % Webs.Length;
        }
    }

    void KillMovement()
    {
        foreach (GameObject movedObject in MovementScriptHolders)
            {
                movedObject.GetComponent<Movement>().enabled = false;
            }
    }
    
}

    
