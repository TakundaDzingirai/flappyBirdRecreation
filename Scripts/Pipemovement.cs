using UnityEngine;

public class Pipemovement : MonoBehaviour
{
    public float speed; // Speed of the pipe
    public float deadZone = -10f; // Position where the pipe is destroyed


    void Start()
    {
        
    }
    void Update()
    {
       
        
            // Move the pipe to the left
            transform.position += Vector3.left * speed * Time.deltaTime;

            // Destroy the pipe if it moves past the dead zone
            if (transform.position.x < deadZone)
            {
                Destroy(gameObject);
            }
        
    }

 
}
