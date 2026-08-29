using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject prefEnemy;
    public int randomIndex;

    public GameObject[] itemsFood;
    public Transform spawnItem; 

    void Start()
    {

        randomIndex = Random.Range(0,4);
        Instantiate(prefEnemy, spawnPoints[randomIndex]);

        randomIndex = Random.Range(0, 10);
        Instantiate(itemsFood[randomIndex], spawnItem);
        
    }

}
