using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMoves : MonoBehaviour
{

    private Rigidbody fisicaCubo;
    private Animator animatorCubo;
    
    public InputAction movimentoCubo;
    Vector3 direcaoCubo;

    public float velocidadeCubo = 8f;
    public bool estaAndando = false;

    public InputAction ataqueCubo;
    
    void Start()
    {

        fisicaCubo = GetComponent<Rigidbody>();
        animatorCubo = GetComponent<Animator>();
        
    }

    private void OnEnable(){

        movimentoCubo.Enable();
        ataqueCubo.Enable();
        ataqueCubo.performed += Atacar;

    }

    private void Disable(){

        movimentoCubo.Disable();
        ataqueCubo.Disable();

    }

    void Update()
    {

        direcaoCubo = movimentoCubo.ReadValue<Vector3>();
        fisicaCubo.linearVelocity = new Vector3(direcaoCubo.x * velocidadeCubo, fisicaCubo.linearVelocity.y, direcaoCubo.z * velocidadeCubo);

        if(direcaoCubo.x != 0 || direcaoCubo.z != 0){

            animatorCubo.SetBool("isWalking", true);
            estaAndando = true;

        }else{

            animatorCubo.SetBool("isWalking", false);
            estaAndando = false;

        }

    }

    void Atacar(InputAction.CallbackContext batata){

        animatorCubo.SetTrigger("attack");

    }

}
