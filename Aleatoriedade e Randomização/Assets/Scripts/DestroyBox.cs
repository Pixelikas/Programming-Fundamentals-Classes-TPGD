using UnityEngine;
using UnityEngine.InputSystem;

public class DestroyBox : MonoBehaviour
{

    public InputAction mouseClick;

    private void OnEnable()
    {
        mouseClick.Enable();
        mouseClick.performed += Clicar;
    }

    private void OnDisable()
    {
        mouseClick.Disable();
        
    }

    void Clicar(InputAction.CallbackContext context)
    {
        
        Destroy(gameObject);

    }

}
