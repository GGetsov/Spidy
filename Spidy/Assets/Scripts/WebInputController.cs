using System;
using UnityEngine;

public class WebInputController : MonoBehaviour
{
    public Action<int> OnButtonPress; 

    void Update()
    {
        MoveOnButtonPress(KeyCode.A, 1);
        MoveOnButtonPress(KeyCode.D, -1);
    }
    void MoveOnButtonPress(KeyCode button, int leftOrRight)
    {
        if (Input.GetKeyDown(button)) 
        OnButtonPress?.Invoke(leftOrRight);
    }

}
