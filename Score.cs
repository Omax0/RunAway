using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public static int counter;

    private void Start()
    {
        counter = 1;
        StartCoroutine(PrintScore());
    }

    IEnumerator PrintScore()
    {
        while(!Player.lose)
        {
            yield return new WaitForSeconds(0.001f);
            counter++;
            score.text = counter.ToString();
        }

        // When players lose, they can see  their score
        score.transform.position = new Vector3(0f, 0f, 0f);
        score.fontSize = 100;
    }
}
