using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 10;
    public float despawnLocation = -44;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        // current location is equal to current location, (-1, 0, 0) * 10uu - go left 10 units every independent frame rate - 0.016 at 60fps
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < despawnLocation)
        {
            Destroy(gameObject);
        }
    }
}
