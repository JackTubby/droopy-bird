using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 2;
    private float timer = 0;
    private float heightOffset = 10;

    void Start()
    {
        spawnClouds();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnClouds();
            timer = 0;
        }
    }

    void spawnClouds()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Instantiate(
            cloud,
            new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0),
            transform.rotation
        );
    }
}
