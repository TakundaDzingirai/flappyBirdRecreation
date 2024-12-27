using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;

public class Gate : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public DisplayScore score;
    void Start()
    {
     score = GameObject.FindGameObjectWithTag("Logic").GetComponent<DisplayScore>();
        if (score == null)
        {
            Debug.Log("Not Found!!!");
           }
        else {
            Debug.Log("Found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            score.Score();
        }
    }
}
