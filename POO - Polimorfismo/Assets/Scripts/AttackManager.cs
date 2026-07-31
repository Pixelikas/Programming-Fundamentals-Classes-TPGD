using UnityEngine;

public class AttackManager : MonoBehaviour
{
   
    public Personagem[] listaPersonagens;

    void Start()
    {
        
        foreach (Personagem personagem in listaPersonagens)
        {

            personagem.Atacar();
            
        }

    }


}
