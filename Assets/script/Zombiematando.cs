using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombiematando : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("PLAYER MORREU");

            // reinicia a cena atual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}