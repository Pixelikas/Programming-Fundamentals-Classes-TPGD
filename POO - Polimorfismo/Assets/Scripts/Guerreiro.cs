using UnityEngine;

public class Guerreiro : Personagem
{   
    public SpriteRenderer spriteGuerreiro;
    
    public override void Atacar()
    {
        
        spriteGuerreiro.color = Color.black;

    }

}
