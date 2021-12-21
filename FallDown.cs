using UnityEngine;

public class FallDown : MonoBehaviour
{
    public static float fallSpeed = 2.5f;

    void Update()
    {
        if (transform.position.y < -5.5f || Player.lose)
            Destroy(gameObject);

        // increase speed every 1000 points (just 1 time!)
        if (Score.counter % 500 == 0)
        {
            fallSpeed *= 1.07f;
            Score.counter += 1;
        }
            
        transform.position -= new Vector3(0f, fallSpeed * Time.deltaTime, 0f);
    }
}
