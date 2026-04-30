using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 5f;

    void Start()
    {
        Destroy(gameObject, 6f);
    }

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    
    
}
