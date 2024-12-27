using UnityEngine;

public class BirdC : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D rigidbody2;
    void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //if statements
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2.linearVelocity = Vector2.up * 10;
        }




    }
}
