using System;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public event EventHandler<OnRespawnArgs> OnRespawn;
    public class OnRespawnArgs : EventArgs
    {
        public Transform webTransform;
    }
    GameObject[] spawnees;
    [SerializeField] Vector3 SpawnPoint;
    [SerializeField] int ySizeOfATile;
    int indexOfObjectBeingChecked;
    int indexOfPreviousObject;


    void Start()
    {
        CreateAnArrayOfObjectsToBeSpawned();
        SpawnChildGameObjectsFromArrayInOrder();
        SetStartingValuesOfIndexes();
    }

    void Update()
    {
        RespawnTheLowestObjectIfHeMovesTooLow();
    }

    private void RespawnTheLowestObjectIfHeMovesTooLow()
    {
        if (IfLowestObjectIsTooLow())
        {
            MoveItOnTopOfTheObjectBeforeThat();
            if (OnRespawn != null) OnRespawn(this, new OnRespawnArgs {webTransform = spawnees[indexOfObjectBeingChecked].transform});
            indexOfObjectBeingChecked = ChangeToNextIndexInArray(indexOfObjectBeingChecked);
            indexOfPreviousObject = ChangeToNextIndexInArray(indexOfPreviousObject);
        }
    }

     private int ChangeToNextIndexInArray(int index)
    {
        index = ++index % spawnees.Length;
        return index;
    }
   

    private void MoveItOnTopOfTheObjectBeforeThat()
    {
        spawnees[indexOfObjectBeingChecked].transform.position = new Vector3(0,spawnees[indexOfPreviousObject].transform.position.y + ySizeOfATile, 0);
    }

    private bool IfLowestObjectIsTooLow()
    {
        return spawnees[indexOfObjectBeingChecked].transform.position.y < SpawnPoint.y;
    }

    private void SetStartingValuesOfIndexes()
    {
        indexOfObjectBeingChecked = 0;
        indexOfPreviousObject = spawnees.Length - 1;
    }
    private void CreateAnArrayOfObjectsToBeSpawned()
    {
        spawnees = GetComponent<IControlledObjects>().GetControlledObjects();
    }

    private void SpawnChildGameObjectsFromArrayInOrder()
    {
        for (int i = 0; i < spawnees.Length; i++)
        {
            InstantiateGameObjectsAsChildren(i);
            ArrangeSpawnedObjectsAlongYAxis(i);
        }
    }

    private void InstantiateGameObjectsAsChildren(int i)
    {
        spawnees[i] = Instantiate(spawnees[i]);
        spawnees[i].transform.SetParent(gameObject.transform);
    }

    private void ArrangeSpawnedObjectsAlongYAxis(int i)
    {
        spawnees[i].transform.position = SpawnPoint + new Vector3(0, i * ySizeOfATile, 0);
    }

}
