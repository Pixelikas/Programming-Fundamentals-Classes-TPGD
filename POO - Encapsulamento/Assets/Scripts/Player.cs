using UnityEngine;

public class Player : Character
{
    private int playerCoins = 10;

    void Start()
    {

        charName = "Mario";
        // charHP = 10;   

    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            TakeDamage(40);

        }
        
    }
}
