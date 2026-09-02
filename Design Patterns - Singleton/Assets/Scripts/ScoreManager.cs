using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    
    public static ScoreManager instance;
    public int playerPoints;
    public TextMeshProUGUI textScore;

    private void Awake()
    {

        if (instance == null)
        {
            
            instance = this;
            
        }
        else
        {

            Destroy(gameObject);

        }     

    }

    public void AddScore(int points)
    {
        
        playerPoints += points;
        textScore.text = "Score: " + playerPoints.ToString();        

    }

}
