using UnityEngine;

public class Enemy : Character
{

    public int enemySoul = 15;
    void Start()
    {

        charName = "Bowser";
                
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            
            GetHeal(20);

        }
        
    }
}
