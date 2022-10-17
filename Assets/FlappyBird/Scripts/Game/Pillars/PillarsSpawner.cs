using System.Collections;
using UnityEngine;

public class PillarsSpawner : MonoBehaviour
{
    [SerializeField] private GameObject pillarsPrefab;
    [SerializeField] private float ySpawnPosition;
    [SerializeField] private float destroyTime;

    private void Start()
    {
        StartCoroutine(SpawnPillars());
    }

    private IEnumerator SpawnPillars()
    {
        while(true) 
        {
            yield return new WaitForSeconds(1.5f);
            GameObject newObject = GetNewSpawnObject(); 
            Destroy(newObject, destroyTime);   
        }
    }

    private GameObject GetNewSpawnObject()
    {
        Vector3 spawnPosition = GetSpawnPosition();
        GameObject newObject = Instantiate(pillarsPrefab, spawnPosition, Quaternion.identity);

        return newObject;
    }

    private Vector3 GetSpawnPosition()
    {
        return new Vector3(transform.position.x, Random.Range(-ySpawnPosition, ySpawnPosition), transform.position.z);
    }
}
