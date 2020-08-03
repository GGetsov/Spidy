using System;
using UnityEngine;

public class WebInputController : MonoBehaviour
{
    public event EventHandler<GetKeyDownArgs> OnButtonPress;
    public class GetKeyDownArgs : EventArgs
    {
        public int MoveLeftOrRight;
    }
    void Update()
    {
        if ( Input.GetKeyDown(KeyCode.A)) if (OnButtonPress != null) OnButtonPress(this, new GetKeyDownArgs {MoveLeftOrRight = 1});
        
        if ( Input.GetKeyDown(KeyCode.D)) if (OnButtonPress != null) OnButtonPress(this, new GetKeyDownArgs {MoveLeftOrRight = -1});
    
    }

}
