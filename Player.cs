using UnityEngine;

public class Player : MonoBehaviour
{
    public static bool lose = false;
    public GameObject restart, gameOver;

    private void Awake()
    {
        lose = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            lose = true;
            restart.SetActive(true);
            gameOver.SetActive(true);
        }
    }
}
