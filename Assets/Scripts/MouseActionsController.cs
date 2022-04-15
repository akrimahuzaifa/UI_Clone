using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseActionsController : MonoBehaviour
{
    [SerializeField]
    Sprite defaultImage,
           hoverImage,
           selectedImage;

    Sprite[] defaultSpriteContainer;
    Sprite[] activeSpriteContainer;

    Image[] imageHolder;
    Image gameObjectImage;
    
    int dan;
    
    void Start()
    {
        gameObjectImage = gameObject.GetComponent<Image>();
        defaultSpriteContainer = FindObjectOfType<DefaultIcons>().defaultSprites;
        activeSpriteContainer = FindObjectOfType<DefaultIcons>().selectedSprites;
    }

    public void SetDefaultImage()
    {
        imageHolder = GameObject.Find("SubPanelControls").GetComponentsInChildren<Image>();
        for(int i = 0; i < imageHolder.Length; i++)
        {
            imageHolder[i].sprite = defaultSpriteContainer[i];
        }
    }

    public void SelectedObj()
    {
        imageHolder = GameObject.Find("SubPanelControls").GetComponentsInChildren<Image>();
        for (int i = 0; i < imageHolder.Length; i++)
        {
            if (i == dan)
            {
                gameObjectImage.sprite = activeSpriteContainer[dan];
            }
            else
            {
                imageHolder[i].sprite = defaultSpriteContainer[i];
            }
        }
    }

    public void OnPointerEnter()
    {
        if (gameObjectImage.sprite != selectedImage )
        {
            gameObjectImage.sprite = hoverImage;
        }
    }
    public void OnPointerExit()
    {
        if(gameObjectImage.sprite != selectedImage)
        {
            gameObjectImage.sprite = defaultImage;
        } 
    }

    public void OnClick()
    {
        if (gameObject.name == "AddAndSelect")
        {
            dan = 0;
            FindObjectOfType<FolderInstantiator>().OnClickInstantiatorAddFolder();
        }
        if(gameObject.name == "Other")
        {
            dan = 1;
        }
        if (gameObject.name == "Move")
        {
            dan = 2;
        }
        if (gameObject.name == "Trash")
        {
            dan = 3;
            GameObject.FindObjectOfType<FolderDestroyer>().OnClickDestroyLastAddedFolder();
        }
        SelectedObj();
    }
}
