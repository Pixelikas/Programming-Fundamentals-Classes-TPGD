using System.Collections.Generic;
using UnityEngine;

public class Dictionary : MonoBehaviour
{
    public Dictionary<int, string> weapons = new Dictionary<int, string>();
            
    void Start()
    {

        weapons.Add(0, "Axe");        
        Debug.Log(weapons[0]);

    }

}