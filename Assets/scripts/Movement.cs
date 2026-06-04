using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public Vector3 screenPosition, worldPosistion;
    public float distance;
    public LayerMask ground;
    public Stats stats;
    public AutoAttack autoAttack;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stats = GetComponent<Stats>();
        autoAttack = GetComponent<AutoAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed)
        { 
            return;
        }
        StopAllCoroutines();
        StartCoroutine(Moves());

    }

    private IEnumerator Moves()
    {
        if (!autoAttack.isAttacking)
        {
            screenPosition = Input.mousePosition;
            Ray ray = Camera.main.ScreenPointToRay(screenPosition);
            if (Physics.Raycast(ray, out RaycastHit hit, 100, ground))
            {
                worldPosistion = hit.point;
                worldPosistion.y = transform.position.y;
            }
            distance = Vector3.Distance(worldPosistion, transform.position);
            //screenPosition.z = Camera.main.nearClipPlane + ground;
            //worldPosistion = Camera.main.ScreenToWorldPoint(screenPosition);
            float time = distance / stats.speed;
            for (float t = 0; t < 1; t += Time.deltaTime / time)
            {
                transform.position = Vector3.Lerp(transform.position, worldPosistion, t);
                yield return new WaitForEndOfFrame();
            }
            yield return null;
            //transform.position = worldPosistion;
        }
    }
}
