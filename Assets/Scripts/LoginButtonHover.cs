using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LoginButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Color32 original;
    public Color32 changedalpha;

    private void Start()
    {
        original = gameObject.GetComponent<Image>().color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //buttonColor.a = 127.5f;
        gameObject.GetComponent<Image>().color = changedalpha;
       // throw new System.NotImplementedException();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        gameObject.GetComponent<Image>().color = original;
    
       // throw new System.NotImplementedException();
    }
}
