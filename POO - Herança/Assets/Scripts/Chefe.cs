using UnityEngine;

public class Chefe : Personagem
{
    public int fase;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log(nome + " chefe da fase " +  fase + " apareceu! :D");
        
    }
 
}
