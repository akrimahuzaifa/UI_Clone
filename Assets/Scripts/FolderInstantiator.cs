using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FolderInstantiator : MonoBehaviour
{
    public GameObject folderPrefab;
    public GameObject folderPanel;
    [HideInInspector] public GameObject folderHolder;
    public int folderNumber = 1;

    float posX = 96.3f;
    float posY = 362.2f;

    public void OnClickInstantiatorAddFolder()
    {      
        folderHolder = Instantiate(folderPrefab, folderPanel.transform);
        folderHolder.transform.position = new Vector3(posX, posY, 0);
        folderHolder.GetComponentInChildren<Text>().text = "Folder " + folderNumber;
        posX += 50f;
        folderNumber++;
        Debug.Log(folderPanel.transform.childCount);
    }
}
