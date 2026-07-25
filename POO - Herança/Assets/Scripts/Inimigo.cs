using UnityEngine;

public class Inimigo : Personagem
{
   
    public string tipo;

    public void Atacar()
    {
        
        Debug.Log(nome + " atacou com dano de " + dano);        

    }

    void OnMouseDown()
    {
        
        Atacar();

    }

}
