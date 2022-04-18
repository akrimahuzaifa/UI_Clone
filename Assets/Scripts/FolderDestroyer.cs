using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderDestroyer : MonoBehaviour
{
    GameObject folderPanel;
    GameObject lastChildObject;

    private void Start()
    {
        folderPanel = FindObjectOfType<FolderInstantiator>().folderPanel;
    }
    public void OnClickDestroyLastAddedFolder()
    {
        if (folderPanel.transform.childCount > 0)
        {
            int lastChildIndex = folderPanel.transform.childCount - 1;
            lastChildObject = folderPanel.transform.GetChild(lastChildIndex).gameObject;
            Destroy(lastChildObject);
            FindObjectOfType<FolderInstantiator>().folderNumber--;
            DataBase.folderCount--;
        }
    }
}
