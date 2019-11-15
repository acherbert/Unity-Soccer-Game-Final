
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

bool gameHasEnded = false;


public float restartDelay = 1f;

public GameObject completeLevel1UI;
public void CompleteLevel ()
{
    completeLevel1UI.SetActive(true);
}
public void EndGame ()
{
    if(gameHasEnded == false)

{   
    gameHasEnded = true;
    Debug.Log("GAME OVER");
   Invoke("Restart", restartDelay);
}
}

void Restart()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}



}
