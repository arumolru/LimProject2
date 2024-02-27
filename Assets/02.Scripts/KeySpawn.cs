using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySpawn : MonoBehaviour
{
    public GameObject key;
    public GameObject hardStageKey;
    public GameObject hardStageKey2;

    public Transform[] spawnZone1;
    public Transform[] spawnZone2;
    public Transform[] spawnZone3;

    private void Awake()
    {
        int randomIndex = Random.Range(0, spawnZone1.Length);
        Transform selectedPosition1 = spawnZone1[randomIndex];

        Instantiate(key, selectedPosition1.position, selectedPosition1.rotation);

        int hardRandomIndex = Random.Range(0, spawnZone2.Length);
        Transform transform1 = spawnZone2[hardRandomIndex];
        Transform selectedPosition2 = transform1;

        Instantiate(hardStageKey, selectedPosition2.position, selectedPosition2.rotation);

        int hardRandomIndex2 = Random.Range(0, spawnZone3.Length);
        Transform selectedPosition3 = spawnZone3[hardRandomIndex2];

        Instantiate(hardStageKey2, selectedPosition3.position, selectedPosition3.rotation);
    }
}
