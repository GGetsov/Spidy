using System;
using UnityEngine;

public class YAxisMover : MonoBehaviour
{
    public event Action OnCorrectMove;
    public event Action OnWrongMove;

    int indexOfWeb;
    GameObject[] Webs;
    WebInputController webController;

    void Start()
    {
        indexOfWeb = 0; 
        Webs = GetComponent<IControlledObjects>().GetControlledObjects();
        webController = GetComponent<WebInputController>();
        webController.OnButtonPress += MoveAlongYAxis;
        OnWrongMove += DisableFurtherMovement;
   }

    void MoveAlongYAxis (int direction) 
    {
        Webs[indexOfWeb].transform.position += new Vector3(direction,0,0);
        if (Webs[indexOfWeb].transform.position.x == 0)
        {
            OnCorrectMove?.Invoke();
            indexOfWeb = (indexOfWeb + 1) % Webs.Length;
        } 
        else OnWrongMove?.Invoke(); 
        
    }

    public void DisableFurtherMovement()
    {
        webController.OnButtonPress -= MoveAlongYAxis;
    }
 
    

}
