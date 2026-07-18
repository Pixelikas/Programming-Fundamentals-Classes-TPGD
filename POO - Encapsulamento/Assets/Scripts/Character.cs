using UnityEngine;

public class Character : MonoBehaviour
{

    public string charName;
    public float charSpeed = 10f;

    // private int charHP = 100;
    [SerializeField] protected int charHP = 100;

    public void TakeDamage(int damage)
    {
        
        charHP -= damage;
        Debug.Log("Vida: " + charHP);

    }

    public void GetHeal(int heal)
    {
        
        charHP = charHP + heal;
        Debug.Log("Vida: " + charHP);

    }

}
