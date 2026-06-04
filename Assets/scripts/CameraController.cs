using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
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
            transform.position = new Vector3(player.transform.position.x, 8, player.transform.position.z - 7);

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

    public void OnPointerExit(PointerEventData eventData)
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }
}
