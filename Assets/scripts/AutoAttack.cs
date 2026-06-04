using UnityEngine;
using UnityEngine.InputSystem;

public class AutoAttack : MonoBehaviour
{
    public Stats stats;
    public GameObject Projectile,temp;
    public GameObject Enemy;
    public bool isAttacking;

    public float cooldown;
    private float downcool;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stats = GetComponent<Stats>();
        temp = Projectile;
        downcool = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attack(InputAction.CallbackContext ctx)
    { 
        if (!ctx.performed)
        {
            return;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, 100))
        {
            if (hit.collider.gameObject.CompareTag("Enemy"))
            {
                isAttacking = true;
                Debug.Log("Enemy hit");
                Enemy = hit.collider.gameObject;
                float distance = Vector3.Distance(hit.collider.gameObject.transform.position, transform.position);
                if (distance <= stats.attackRange)
                {
                    GameObject projectile = Instantiate(temp, transform.position, Quaternion.identity);
                    projectile.GetComponent<Projectile>().autoAttack = this;
                    projectile = null;
                    temp = Projectile;

                }
            }
        }
    }
}
