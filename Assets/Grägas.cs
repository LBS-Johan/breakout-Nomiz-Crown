using UnityEngine;
using UnityEngine.SceneManagement;

public class Grägas : MonoBehaviour
{
    public float delay = 0.05f; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ScoreManager.Instance != null)
        {
            ScoreManager.Instance.AddScore(1);
        }

        Invoke(nameof(DeactivateBrick), delay);
    }

    private void DeactivateBrick()
    {
        gameObject.SetActive(false);
    }
}