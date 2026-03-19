using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    [SerializeField] private float spawnRangeX = 12;
    [SerializeField] private float spawnPosZ = 20;
    [SerializeField] private float startDelay = 2.0f;

    void Start()
    {
        float randomTime = Random.Range(1.0f, 3.0f);

        InvokeRepeating("SpawnRandomAnimal", startDelay, randomTime);
    }

    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPos = new Vector3(randomX, 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
