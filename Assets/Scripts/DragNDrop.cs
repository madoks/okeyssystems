using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragNDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    public RectTransform Target;
    public RectTransform posF;
    public float smoothSpeed;
    private bool suelto;
    public float o_x;
    public float o_y;

    public void Start()
    {
        Debug.Log(canvas.transform.localScale);
    }

    public void Update()
    {

        if(suelto)
        {
            
            //Vector2 smoothPos = Vector2.Lerp(RT.anchoredPosition, DesirePos, smoothSpeed);
            transform.position = Target.position;
            Debug.Log(transform.position);
            suelto = false;
        }
    }
   
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
        
        suelto = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector3 pos = eventData.position*canvas.transform.localScale;//canvas.scaleFactor;
        transform.position = pos + Target.position - new Vector3(o_x, o_y,0);         
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Vector3 pos = eventData.position*canvas.transform.localScale;
        transform.position = pos + Target.position - new Vector3(o_x, o_y,0);
        Debug.Log("OnEndDrag");
        if (transform.position == posF.position)
        {
            Debug.Log("Siii llegue");
        }
        Debug.Log(transform.position);
        Debug.Log(posF.position);
        suelto = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointDown");
    }

   
}
