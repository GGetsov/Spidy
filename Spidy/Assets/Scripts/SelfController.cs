using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfController : MonoBehaviour,IControlledObjects
{
    public GameObject[] GetControlledObjects()
    {
        GameObject[] Self = new GameObject[1];
        Self[0] = gameObject;
        return Self;
    }
}
