using UnityEngine;
using UnityEngine.SceneManagement;

public class fimfase : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            SceneManager.LoadScene("fase1");
        }
    }
}
