using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameEnd= false;
    public float delay= 2f;
    public GameObject completeLevelUI;
    public void CompleteLevel(){
        completeLevelUI.SetActive(true);
    }
    public void GameOver(){
        if (gameEnd==false){
            gameEnd= true;
            Debug.Log("Game Over!!");
            Invoke("Restart", delay);
        }
    }
    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
