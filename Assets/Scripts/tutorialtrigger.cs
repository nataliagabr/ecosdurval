using UnityEngine;

public class TutorialTrigger : MonoBehaviour
{
    public GameObject placa;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            placa.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            placa.SetActive(false);
        }
    }
}
