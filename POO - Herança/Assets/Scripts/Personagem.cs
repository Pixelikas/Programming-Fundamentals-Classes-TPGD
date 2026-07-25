using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome;
    public int vida;
    public int dano;

    public void ReceberDano(int valorDano)
    {
        Debug.Log("Dano causado: " + valorDano);     
    }

    void OnMouseDown()
    {
        ReceberDano(dano);
    }
}
