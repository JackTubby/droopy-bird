using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float despawnLocation = -44;

    void Start() { }

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < despawnLocation)
        {
            Destroy(gameObject);
        }
     }
}
