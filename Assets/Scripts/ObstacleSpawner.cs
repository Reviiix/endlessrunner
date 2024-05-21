using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstacle;
    public Transform spawnpoint;
    public int time;

    private void Start()
    {
        StartCoroutine(SpawnProcess());
    }

    private IEnumerator SpawnProcess()
    {
        var t = Random.Range(1, 4);
        yield return new WaitForSeconds(t);
        SpawnShit();
        yield return new WaitForSeconds(t);
        StartCoroutine(SpawnProcess());
    }

    private void SpawnShit()
    {
        Instantiate(obstacle, spawnpoint);
    }
}
