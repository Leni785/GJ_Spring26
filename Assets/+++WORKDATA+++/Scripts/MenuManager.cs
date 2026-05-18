using UnityEngine;

public class MenuManager : MonoBehaviour
{
  [SerializeField] CameraSwitch  cameraSwitch;
  [SerializeField] GameObject MainMenuPanel;
  [SerializeField] GameObject CreditsPanel;
  
  [SerializeField] GameObject WinPanel;
  [SerializeField] GameObject LosePanel;
  
public void  StartGame()
{
  MainMenuPanel.SetActive(false);
  cameraSwitch.StartTimer();
}
  
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
  MainMenuPanel.SetActive(true);
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
}

