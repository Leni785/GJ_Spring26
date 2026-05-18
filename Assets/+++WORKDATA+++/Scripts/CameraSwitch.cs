using System.Collections;
using TMPro;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField] PlayerMovement PlayerMovement;
    [SerializeField] CinemachineCamera SideViewCamera;
    [SerializeField] CinemachineCamera TopViewCamera;

    [SerializeField] int TimeCounter = 11;
    [SerializeField] TextMeshProUGUI textTimer;
    
   public void StartTimer()
    {
       StartCoroutine(Timer());
    }
    
    IEnumerator Timer()
    {
        while (TimeCounter > 0)
        {
            TimeCounter--;
            textTimer.text = TimeCounter.ToString();
            yield return new WaitForSeconds(1f);
            
            if (TimeCounter == 0)
            {
                ResetTimer();
            }
        }
    }

    private void SwitchPerspective()
    {
        if (SideViewCamera.Priority == 0)
        {
            SideViewCamera.Priority = 1;
            TopViewCamera.Priority = 0;
           // PlayerMovement.canJump = true;
        }
        else
        {
            SideViewCamera.Priority = 0;
            TopViewCamera.Priority = 1;
            //PlayerMovement.canJump = false;
        }
    }
    
    private void ResetTimer()
    {
        TimeCounter = 11;
        SwitchPerspective();
    }
}

