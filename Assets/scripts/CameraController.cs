using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    private bool isPressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed)
        {
            transform.position = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z - 7);

        }
    }

    public void Follow(InputAction.CallbackContext ctx)
    { 
        if (!ctx.performed)
        { 
            isPressed = false;
            return;
        }
        if (ctx.performed)
        { 
            isPressed = true;
        }

    }
}
