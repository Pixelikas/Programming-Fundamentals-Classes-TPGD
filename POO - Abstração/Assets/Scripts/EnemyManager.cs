using UnityEngine;

public class EnemyManager : MonoBehaviour
{  
    public Inimigo[] listaInimigos;

    void Start()
    {
        
        foreach (Inimigo inimigo in listaInimigos)
        {

            inimigo.Pular();
            
        }

    }

}
