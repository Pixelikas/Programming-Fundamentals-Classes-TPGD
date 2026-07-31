using UnityEngine;

public class Arqueiro : Personagem
{   

    Vector3 scaleSize = new Vector3 (2, 2, 2);

    public override void Atacar()
    {
        
        transform.localScale += scaleSize;

    }

}
