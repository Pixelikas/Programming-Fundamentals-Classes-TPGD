using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public Transform spawnPos;
    public GameObject prefabInimigo;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Instantiate(prefabInimigo, spawnPos);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
