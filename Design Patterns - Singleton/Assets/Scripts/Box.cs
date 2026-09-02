using UnityEngine;

public class Box : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        ScoreManager.instance.AddScore(3);
        // Destroy(gameObject);

    }

}
