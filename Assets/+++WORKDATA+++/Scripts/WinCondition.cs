using UnityEditor;
using UnityEngine;

public class WinCondition : MonoBehaviour
{
  [SerializeField] MenuManager manager;

  [SerializeField] private GameObject Player;
  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
    {
      manager.WinGame();
      Player.GetComponent<CharacterController>().enabled = false;
    }
  }
}
