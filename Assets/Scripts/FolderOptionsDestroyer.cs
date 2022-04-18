using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderOptionsDestroyer : MonoBehaviour
{
    GameObject folderOptionPanel;
    GameObject lastChildObj;

    private void Start()
    {
        folderOptionPanel = FindObjectOfType<FolderOptionsInstantiator>().folderOptionsPanel;
    }

    public void OnClickDestroyLastAddedFolderOption()
    {
        if(folderOptionPanel.transform.childCount > 0)
        {
            int lastIndexofChild = folderOptionPanel.transform.childCount - 1;
            lastChildObj = folderOptionPanel.transform.GetChild(lastIndexofChild).gameObject;
            Destroy(lastChildObj);
            FindObjectOfType<FolderOptionsInstantiator>().posY += 70f;
            DataBase.detailOptionCount--;
        }   
    }
}
