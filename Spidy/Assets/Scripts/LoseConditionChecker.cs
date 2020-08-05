using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseConditionChecker : MonoBehaviour
{
    GameObject[] Webs;
    int IndexOfCheckedWeb = 0;
    [SerializeField] GameObject[] MovementScriptHolders;

    void Start()
    {
        Webs = GetComponent<IControlledObjects>().GetControlledObjects();
    }

    void Update()
    {
        if (Webs[IndexOfCheckedWeb].transform.position.y < -3.5 )
        {
            if (Webs[IndexOfCheckedWeb].transform.position.x != 0 ) 
            {
                foreach (GameObject movedObject in MovementScriptHolders)
                {
                    movedObject.GetComponent<Movement>().enabled = false;
                }
            }   

            IndexOfCheckedWeb = ++IndexOfCheckedWeb % Webs.Length;
        }
    }
}
