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

    private void Start()
    {
        if (DataBase.folderCount != 0)
        {
            for (int i = 0; i < DataBase.folderCount; i++)
            {
                ValuesFromDatabaseFolder();
            }
        }
    }

    public void OnClickInstantiatorAddFolder()
    {
        ValuesFromDatabaseFolder();
        DataBase.folderCount++;
    }
    public void ValuesFromDatabaseFolder()
    {
        folderHolder = Instantiate(folderPrefab, folderPanel.transform);
        folderHolder.GetComponentInChildren<Text>().text = "Folder " + folderNumber;
        folderNumber++;
    }
}
