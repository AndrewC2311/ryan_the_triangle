using UnityEngine;

public class Ground : MonoBehaviour
{

    private SpriteRenderer renderer;
    public Player player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.coins >= 10)
        {
            renderer.color = new Color(0.8f, 0.4f, 0.1f, 1f);
        }
    }
}
