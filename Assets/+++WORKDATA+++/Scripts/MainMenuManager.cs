using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] GameObject CreditsPanel;
    
    public void StartGame()
    {
        RestartGame();
    }
    
    public void ExitGame()
    {
        Application.Quit();
    }
    
    public void Credits()
    {
        if (CreditsPanel.activeSelf)
        {
            CreditsPanel.SetActive(false);
        }
        else
        {
            CreditsPanel.SetActive(true);
        }
    }
 
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
