using System.Collections;
using UnityEngine;

public class SpawnBombs : MonoBehaviour
{
    [SerializeField]
    private float waitFor = 1f;
    public GameObject bomb;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update()
    {
        if (Score.counter % 500 == 0)
        {
            waitFor -= waitFor * 0.07f;
        }
    }

    IEnumerator Spawn()
    {
        while(!Player.lose)
        {
            Instantiate(bomb, new Vector2(Random.Range(-2f, 2f), 5.7f), Quaternion.identity);
            yield return new WaitForSeconds(waitFor);
        }
    }
}
