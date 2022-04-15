using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackToFolders : MonoBehaviour
{
    [SerializeField] 
    Sprite  defaultArrow,
            hoverArrow,
            selectedArrow;

    Image imageComponent;

    private void Start()
    {
        imageComponent = gameObject.GetComponent<Image>();
    }
    public void OnArrowPointerEnter()
    {
        imageComponent.sprite = hoverArrow;
    }
    public void OnArrowPointerExit()
    {
        imageComponent.sprite = defaultArrow;
    }

    public void OnArrowPointerDown()
    {
        imageComponent.sprite = selectedArrow;
    }

}
