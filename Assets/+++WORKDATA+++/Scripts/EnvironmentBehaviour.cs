using Unity.VisualScripting;
using UnityEngine;

public class EnvironmentBehaviour : MonoBehaviour
{
  [SerializeField] Animator fallingObject;
  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
    {
      fallingObject.SetTrigger("falling");
    }
  }
}
