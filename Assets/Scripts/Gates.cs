//using UnityEngine;

//public class Gates : MonoBehaviour
//{
//    private void OnTriggerEnter(Collider other)
//    {
//        if (other.CompareTag("Ball"))
//        {
//            Destroy(other.gameObject);

//            Debug.Log("Current Game Score: " );
//        }
//    }
//}
using UnityEngine;

public class Gates : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            Debug.Log("Current Score: " + GameManager.Instance.IncreaseScore());
        }
    }
}