using UnityEngine;

public class cart : MonoBehaviour
{
      void OnCollisionEnter(Collision collision)
      {
        if (collision.gameObject.tag == "Fence")
        {
            Destroy(collision.gameObject);
        }
      }
}
