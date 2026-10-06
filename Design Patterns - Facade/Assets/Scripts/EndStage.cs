using UnityEngine;

public class EndStage : MonoBehaviour
{
    public GameFacade refGameFacade;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            
            refGameFacade.FinalizaFase();

        }

    }

}
