using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] attackerPrefabArray;

    void Update()
    {
        foreach (GameObject thisAttacker in attackerPrefabArray)
        {
            if (IsTimeToSpawn(thisAttacker))
            {
                Spawn(thisAttacker);
            }
        }
    }

    void Spawn(GameObject myGameObject)
    {
        GameObject myAttacker = Instantiate(myGameObject) as GameObject;
        myAttacker.transform.parent = transform;
        myAttacker.transform.position = transform.position;
    }

    bool IsTimeToSpawn(GameObject attackerGameObject)
    {
        Attack attack = attackerGameObject.GetComponent<Attack>();
        float meanSpawnDelay = attack.seenPerSeconds;
        float spawnsPerSeconds = 1 / meanSpawnDelay;
        if (Time.deltaTime > meanSpawnDelay)
        {
            Debug.LogWarning("spwan rate capped by frame rate");
        }

        float threshold = spawnsPerSeconds * Time.deltaTime / 5;
        return (Random.value < threshold);
       
    }



}
