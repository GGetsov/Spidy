using System;
using UnityEngine;

public class YAxisMover : MonoBehaviour
{
    GameObject[] Webs;
    int indexOfWeb = 0;

    void Start()
    {
        Webs = GetComponent<IControlledObjects>().GetControlledObjects();
        WebInputController webController = GetComponent<WebInputController>();
        webController.OnButtonPress += MoveAlongYAxis;
    }

    void MoveAlongYAxis (object sender, WebInputController.GetKeyDownArgs e) 
    {
        Vector3 newPosition = new Vector3 (Webs[indexOfWeb].transform.position.x + e.MoveLeftOrRight,Webs[indexOfWeb].transform.position.y,0);
        Webs[indexOfWeb].transform.position = newPosition;  
        indexOfWeb = (indexOfWeb + 1) % Webs.Length;
    }

}
