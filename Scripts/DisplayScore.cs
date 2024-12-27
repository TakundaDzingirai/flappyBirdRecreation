using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int score = 0;
    public Text textSc;
    public GameObject gameOver;

    public void Score()
    {
        score++;
        textSc.text = score.ToString(); 
        Debug.Log(score);
        Debug.Log(textSc.text);
    }
    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       

    }
    public void GameOver()
    {
        gameOver.SetActive(true);
       

    }
   


}
