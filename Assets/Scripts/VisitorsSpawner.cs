using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisitorsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] visitorsPrefabs;

    [SerializeField] private int visitorsCount;

    [SerializeField] private Vector3 spawnPoint;

    [SerializeField] private Transform visitorsHolder;


    private void Start()
    {
        StartCoroutine(SpawnVisitorCoroutine());
    }

    private IEnumerator SpawnVisitorCoroutine() 
    {
        float delay = 0.4f;

        for (int i = 0; i < visitorsCount; i++)
        {
            Vector3 positionToSpawn = new Vector3(spawnPoint.x + Random.Range(-1f,1f),spawnPoint.y, spawnPoint.z + Random.Range(-1f, 1f));
            Instantiate(visitorsPrefabs[Random.Range(0, visitorsPrefabs.Length)], positionToSpawn, Quaternion.identity, visitorsHolder);
            yield return new WaitForSeconds(delay);
        }
    }
}
