using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipePrefab;

    public float spawnRate = 2f;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnRate)
        {
            float randomY = Random.Range(-2f, 2f);
            
            Vector3 spawnPos = new Vector3(transform.position.x, randomY, 0);
            
            Instantiate(pipePrefab, spawnPos, Quaternion.identity);
            timer = 0f;
        }
    }
}
