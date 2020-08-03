using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LeftOrRight : MonoBehaviour
{
    void Start()
    {
        Spawn webSpawner = GetComponent<Spawn>();
        webSpawner.OnRespawn += PutWebLeftOrRightRandomly; 
    }
    
    void PutWebLeftOrRightRandomly (object sender, Spawn.OnRespawnArgs e) 
    {
        e.webTransform.position += new Vector3 (LeftOrRightFromCenter(),0,0);
    }

    int LeftOrRightFromCenter ()
    {
        if ( UnityEngine.Random.Range(0, 2) != 0) return 1 ;
        return -1;
    }
}