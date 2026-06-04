using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class CamMove : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public bool hovering,up,down,left,right;
    public GameObject cam;


    public void OnPointerEnter(PointerEventData eventData)
    {
       hovering = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        hovering = false;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float speed = 10f * Time.deltaTime;
        if (hovering)
        {
            if (up)
            {
                cam.transform.Translate(Vector3.forward * speed);
            }
            if (down)
            {
                cam.transform.Translate(Vector3.back * speed);
            }
            if (left)
            {
                cam.transform.Translate(Vector3.left * speed);
            }
            if (right)
            {
                cam.transform.Translate(Vector3.right * speed);
            }
        }
    }
}
