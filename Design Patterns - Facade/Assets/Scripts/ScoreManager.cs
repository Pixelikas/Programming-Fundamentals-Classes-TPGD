using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public GameObject containerScore;

    public void AtualizarScore()
    {
        
        containerScore.SetActive(true);
        
    }

}
