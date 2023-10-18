using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [Header("Spawn Cube Object")]
    public GameObject spawnCube;
    [Header("Default Difficulty")]
    public float difficulty = 40f;

    float spawn;
    // Update is called once per frame
    void Update()
    {
        spawn = difficulty * Time.deltaTime;
        difficulty = Time.deltaTime * 4f;
        while (spawn > 0)
        {
            spawn -= 1;
            //Vector3 v3Pos
        }
    }
}
