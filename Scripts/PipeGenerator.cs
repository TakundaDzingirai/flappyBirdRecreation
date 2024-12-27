using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    public GameObject pipe; // Pipe prefab
    private float timer = 0; // Tracks time for spawning pipes
    public float spawnRate = 3; // Interval between pipe spawns
    public float pipeOffset = 2; // Randomization range for pipe height
    //public float speedIncreaseInterval = 20; // Time interval to increase speed
    //private float speedTimer = 0; // Tracks time for speed increases
    //public float currentspeed = 2; // Current speed of the pipes
    //public float speedInc = 0.5f; // Amount to increase speed

    void Start()
    {
        Spawn(); // Spawn the first pipe immediately
    }

    void Update()
    {
        // Handle pipe spawning
        timer += Time.deltaTime;
        if (timer >= spawnRate)
        {
            Spawn();
            timer = 0; // Reset the spawn timer
        }

      
    }

    void Spawn()
    {
        // Calculate vertical range for pipe spawning
        float lowestP = transform.position.y - pipeOffset;
        float highestP = transform.position.y + pipeOffset;

        // Instantiate the pipe at a randomized vertical position
         Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestP, highestP), 0), transform.rotation);

        //// Pass the current speed to the pipe's Pipemovement script
        //Pipemovement pipemovement = newpipe.GetComponent<Pipemovement>();
        //if (pipemovement != null)
        //{
        //    pipemovement.SetSpeed(currentspeed); // Set the pipe's speed using a method
        //}
    }
}
