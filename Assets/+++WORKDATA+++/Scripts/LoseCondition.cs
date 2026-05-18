using UnityEditor;
using UnityEngine;

public class LoseCondition : MonoBehaviour
{
  [SerializeField] MenuManager manager;

  [SerializeField] private GameObject Player;
  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player")
    {
      manager.LoseGame();
      Player.GetComponent<CharacterController>().enabled = false;
    }
  }
}
