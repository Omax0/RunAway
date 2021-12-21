using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        // realization of the explosion after game over
        if (Player.lose)
        {
            player.SetActive(false);
            transform.position = player.transform.position;
            transform.localScale += new Vector3(0.5f, 0.5f, 0.5f);
            if (transform.localScale.x > 4f)
                Destroy(gameObject);
        }
    }
}
