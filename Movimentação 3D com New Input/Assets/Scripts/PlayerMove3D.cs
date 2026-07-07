using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove3D : MonoBehaviour
{

    private Rigidbody playerPhysics;

    public InputAction playerMove;
    public InputAction playerJump;

    public float playerVelocity = 5f;
    public float playerJumpHeight = 10f;

    public bool isJumping = false;

    Vector3 playerDirection;

    private void OnEnable(){

        playerMove.Enable();
        playerJump.Enable();
        playerJump.performed += Jump;

    }

    private void OnDisable(){

        playerMove.Disable();
        playerJump.Enable();

    }


    void Start()
    {

        playerPhysics = GetComponent<Rigidbody>();
        
    }

    void Update()
    {

        playerDirection = playerMove.ReadValue<Vector3>();
        playerPhysics.linearVelocity = new Vector3(playerDirection.x * playerVelocity, playerPhysics.linearVelocity.y, playerDirection.z * playerVelocity);
        
    }

    void Jump(InputAction.CallbackContext context){

        if(!isJumping){

            playerPhysics.linearVelocity = new Vector3(playerPhysics.linearVelocity.x, playerJumpHeight, playerPhysics.linearVelocity.z);
            isJumping = true;

        }

    }

    void OnCollisionEnter(Collision col){

        isJumping = false;

    }

}
