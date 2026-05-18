using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
  [SerializeField] CameraSwitch cameraSwitch;
  
  [SerializeField] GameObject WinPanel;
  [SerializeField] GameObject LosePanel;
  
  
public void LoseGame()
{
  LosePanel.SetActive(true);
}
public void WinGame()
{
  WinPanel.SetActive(true);
}

public void Home()
{
  SceneManager.LoadScene("MainMenuScene");
}
}

