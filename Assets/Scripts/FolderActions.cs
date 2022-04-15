using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FolderActions : MonoBehaviour
{
    [SerializeField]
    Sprite  folderDefaultImage,
            folderHoverImage,
            folderSelectedImage;

    Image imageComponent;

/*    // Choose the time you want between clicks to consider it a double click
    float doubleClickTime = .2f, lastClickTime;*/

    private void Start()
    {
        imageComponent = gameObject.GetComponent<Image>();
    }

    private void Update()
    {
/*        // Checking left mouse button click, you could choose the input you want here
        if (Input.GetMouseButtonDown(0))
        {
            float timeSinceLastClick = Time.time - lastClickTime;

            if (timeSinceLastClick <= doubleClickTime)
            {
                Debug.Log("Double click");
            }  
            else
            {
                Debug.Log("Normal click");
                
            }
            lastClickTime = Time.time;
        }*/
    }

    public void DefaultFolderImage()
    {
        imageComponent.sprite = folderDefaultImage;      
    }
    public void OnFolderPointerEnter()
    {
        if(imageComponent.sprite != folderSelectedImage)
        {
            imageComponent.sprite = folderHoverImage;
        }
    }
    public void OnFolderPointerExit()
    {
        if(imageComponent.sprite != folderSelectedImage)
        {
            DefaultFolderImage();
        } 
    }
    public void OnFolderPointerDown()
    {
        imageComponent.sprite = folderSelectedImage;
    }
    public void OnFolderOpen()
    {
        
    }
}
