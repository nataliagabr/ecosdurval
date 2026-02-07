using UnityEngine;

public class ZombieTrigger : MonoBehaviour
{
    public GameObject zombiePrefab;
    public Transform[] pontosDeSpawn;
    public bool usarUmaVez = true;

    private bool jaAtivou = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !jaAtivou)
        {
            SpawnZombies();

            if (usarUmaVez)
                jaAtivou = true;
        }
    }

    void SpawnZombies()
    {
        foreach (Transform ponto in pontosDeSpawn)
        {
            Instantiate(zombiePrefab, ponto.position, Quaternion.identity);
        }
    }
}