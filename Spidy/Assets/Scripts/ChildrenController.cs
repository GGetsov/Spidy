using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildrenController : MonoBehaviour, IControlledObjects
{
    [SerializeField] GameObject[] arrayOfControlledObjects;

    public GameObject[] GetControlledObjects()
    {
        return arrayOfControlledObjects;
    }
   
}
