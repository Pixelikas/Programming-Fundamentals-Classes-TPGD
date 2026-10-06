using UnityEngine;

public class GameFacade : MonoBehaviour
{   
    public AudioManager refAudioManager;
    public ScoreManager refScoreManager;
    public UIManager refUIManager;
    public SaveManager refSaveManager;

    public void FinalizaFase()
    {
        
        refAudioManager.TocarSomVitoria();
        refScoreManager.AtualizarScore();
        refUIManager.MostrarTelaVitoria();
        refSaveManager.SalvarJogo();

    }

}
