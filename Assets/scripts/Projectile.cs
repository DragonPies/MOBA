using System.Collections;
using Unity.VisualScripting;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using static UnityEditor.ShaderGraph.Internal.KeywordDependentCollection;

public class Projectile : MonoBehaviour
{
    public AutoAttack autoAttack;
    //private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
        StartCoroutine(travel());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator travel()
    {
       float distance = Vector3.Distance(autoAttack.Enemy.transform.position, transform.position);
        float time = distance / autoAttack.stats.speed;
        for (float t = 0; t < 1; t += Time.deltaTime / time)
        {
            transform.position = Vector3.Lerp(transform.position, autoAttack.Enemy.transform.position, t);
            yield return new WaitForEndOfFrame();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

            if (collision.gameObject.CompareTag("Enemy"))
            {
                collision.gameObject.GetComponent<Stats>().health -= 10;
                autoAttack.isAttacking = false;
                Destroy(gameObject);
                
        }
    }
}
