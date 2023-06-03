using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    float time = 2f;
    float repeatTime = 0.5f;
    [SerializeField] GameObject ball;


    void Start()
    {
        InvokeRepeating("Spawn",time, repeatTime);
    }

   void Spawn()
    {
        Instantiate(ball,RandomSpawnPos(),ball.transform.rotation);
    }

    Vector3 RandomSpawnPos()
    {
        return new Vector3(0,Random.Range(10,20), Random.Range(-28,28));
    }



}
