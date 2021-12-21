using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Main");
        
        // set up default speed
        FallDown.fallSpeed = 2.5f;
    }
}
