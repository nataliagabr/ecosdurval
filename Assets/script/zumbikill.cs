using UnityEngine;

public class zumbikill : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            Destroy(collision.gameObject); // Mata a Laura

            // Aqui você pode adicionar som ou animação de morte
            // AudioSource.PlayClipAtPoint(deathSound, transform.position);
        }
    }
}

