using UnityEngine;

public class Enemy : MonoBehaviour
{
  
    void OnMouseDown()
    {
        
        ScoreManager.instance.AddScore(55);
        Destroy(gameObject);

    }

}
