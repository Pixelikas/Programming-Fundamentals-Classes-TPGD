using UnityEngine;

public class Mago : Personagem
{  
    public override void Atacar()
    {
        
        Destroy(gameObject);

    }

}
