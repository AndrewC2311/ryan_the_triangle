using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public AudioClip coinSFX;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Player player = collision.gameObject.GetComponent<Player>();
            player.coins += 1;
            player.PlaySFX(coinSFX);
            Destroy(gameObject);
        }
    }
}

