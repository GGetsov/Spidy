using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    GameObject[] movedObjects;
    [SerializeField] Vector3 movementSpeed;
    [SerializeField] Vector3 acceleration;
    
    
    void Start()
    {
        movedObjects = GetComponent<IControlledObjects>().GetControlledObjects();
    }

    void Update()
    {
        MoveAllObjectsFromArray();
        IncreaseMovementSpeed();
    }

    private void IncreaseMovementSpeed()
    {
        movementSpeed += acceleration * Time.deltaTime;
    }

    private void MoveAllObjectsFromArray()
    {
        foreach (GameObject movedObject in movedObjects)
        {
            movedObject.transform.position += movementSpeed * Time.deltaTime;
        }
    }
}
