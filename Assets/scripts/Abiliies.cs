using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class Abiliies : MonoBehaviour
{
    public GameObject Q, W, E, R;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QAbility(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed)
        {
            return;
        }
        StartCoroutine(QQ());
    }

    private IEnumerator QQ()
    {
        Q.GetComponent<RectTransform>().sizeDelta = new Vector2(Q.GetComponent<RectTransform>().sizeDelta.x * 0.5f, Q.GetComponent<RectTransform>().sizeDelta.y * 0.5f);
        yield return new WaitForSeconds(.5f);
        Q.GetComponent<RectTransform>().sizeDelta = new Vector2(Q.GetComponent<RectTransform>().sizeDelta.x * 2f, Q.GetComponent<RectTransform>().sizeDelta.y * 2f);
    }
    public void WAbility(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed) {
            return;
        }
        StartCoroutine(WW());
    }

    private IEnumerator WW()
    {
        W.GetComponent<RectTransform>().sizeDelta = new Vector2(W.GetComponent<RectTransform>().sizeDelta.x * 0.5f, W.GetComponent<RectTransform>().sizeDelta.y * 0.5f);
        yield return new WaitForSeconds(.5f);
        W.GetComponent<RectTransform>().sizeDelta = new Vector2(W.GetComponent<RectTransform>().sizeDelta.x * 2f, W.GetComponent<RectTransform>().sizeDelta.y * 2f);
    }

    public void EAbility(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed) {
            return;
        }
        StartCoroutine(EE());
    }

    private IEnumerator EE()
    {
        E.GetComponent<RectTransform>().sizeDelta = new Vector2(E.GetComponent<RectTransform>().sizeDelta.x * 0.5f, E.GetComponent<RectTransform>().sizeDelta.y * 0.5f);
        yield return new WaitForSeconds(.5f);
        E.GetComponent<RectTransform>().sizeDelta = new Vector2(E.GetComponent<RectTransform>().sizeDelta.x * 2f, E.GetComponent<RectTransform>().sizeDelta.y * 2f);
    }

    public void RAbility(InputAction.CallbackContext ctx)
    {
        if (!ctx.performed) {
            return;
        }
        StartCoroutine(RR());
    }

    private IEnumerator RR()
    {
        R.GetComponent<RectTransform>().sizeDelta = new Vector2(R.GetComponent<RectTransform>().sizeDelta.x * 0.5f, R.GetComponent<RectTransform>().sizeDelta.y * 0.5f);
        yield return new WaitForSeconds(.5f);
        R.GetComponent<RectTransform>().sizeDelta = new Vector2(R.GetComponent<RectTransform>().sizeDelta.x * 2f, R.GetComponent<RectTransform>().sizeDelta.y * 2f);
    }
}
