using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class BirdControls : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rigidbody2D;
    public float flapStrength;
    public DisplayScore displayScore;
    

    private bool isAlive;  
    void Start()
    {
        //rigidbody2D = GetComponent<Rigidbody2D>();
        displayScore=GameObject.FindGameObjectWithTag("Logic").GetComponent<DisplayScore>();
        isAlive=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& isAlive)
        {
            rigidbody2D.linearVelocity = Vector2.up * flapStrength;
        }else if (transform.position.y < -5.8)
        {
            isAlive=false;
            displayScore.GameOver();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        displayScore.GameOver();

        isAlive=false;
    }

}
