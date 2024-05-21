using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnpoint;

    private void Start()
    {
        StartCoroutine(SpawnProcess());
    }

    private IEnumerator SpawnProcess()
    {
        yield return new WaitForSeconds(1);
        SpawnShit();
        yield return new WaitForSeconds(1);
        StartCoroutine(SpawnProcess());
    }

    private void SpawnShit()
    {
        Instantiate(obstacle, spawnpoint);
    }
}
