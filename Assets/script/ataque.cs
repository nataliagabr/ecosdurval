using UnityEngine;

public class ataque : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Colidiu com: " + collision.name);

        // procura a tag enemy no pai
        if (collision.transform.root.CompareTag("enemy"))
        {
            Debug.Log("INIMIGO ATINGIDO");
            Destroy(collision.transform.root.gameObject);
        }
    }
}

