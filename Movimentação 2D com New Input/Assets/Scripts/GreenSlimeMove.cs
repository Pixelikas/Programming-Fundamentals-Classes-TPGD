using UnityEngine;
using UnityEngine.InputSystem;

public class GreenSlimeMove : MonoBehaviour
{

    public InputAction movimentosSlime;
    private Rigidbody2D fisicaSlime;

    public float velocidadeSlime = 9f;
    Vector2 direcaoSlime;

    private SpriteRenderer imagemSlime;

    public InputAction puloSlime;
    public float alturaPuloSlime = 15f;

    public bool estaNoChao = true;

    private void OnEnable(){

        movimentosSlime.Enable();
        puloSlime.Enable();
        puloSlime.performed += Pular;

    }

    private void OnDisable(){

        movimentosSlime.Disable();
        puloSlime.Disable();

    }

    void Start()
    {

        fisicaSlime = GetComponent<Rigidbody2D>();
        imagemSlime = GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {

        direcaoSlime = movimentosSlime.ReadValue<Vector2>();
        fisicaSlime.linearVelocity = new Vector2(direcaoSlime.x * velocidadeSlime, fisicaSlime.linearVelocity.y);
        
        if(direcaoSlime.x < 0){

            imagemSlime.flipX = true;

        }else if(direcaoSlime.x > 0){

            imagemSlime.flipX = false;

        }

    }

    void Pular(InputAction.CallbackContext context){

        if(estaNoChao){

            fisicaSlime.linearVelocity = new Vector2(fisicaSlime.linearVelocity.x, alturaPuloSlime);
            estaNoChao = false;

        }

    }

    void OnCollisionEnter2D(Collision2D batata){

        estaNoChao = true;

    }

}
