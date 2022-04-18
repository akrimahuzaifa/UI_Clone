using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolderOptionsInstantiator : MonoBehaviour
{
    public GameObject folderOptionsPrefab;
    public GameObject folderOptionsPanel;
    [HideInInspector] public GameObject folderOptionsHolder;
    [HideInInspector] public float posY;

    private void Start()
    {
        posY = 750f;
        if(DataBase.detailOptionCount != 0)
        {
            for(int i = 0; i < DataBase.detailOptionCount; i++)
            {
                ValuesFromDatabaseOptions();
            }
        }

    }
    public void OnClickInstantiatorAddFolderOption()
    {
        ValuesFromDatabaseOptions();
        DataBase.detailOptionCount++;
    }
    public void ValuesFromDatabaseOptions()
    {
        folderOptionsHolder = Instantiate(folderOptionsPrefab, folderOptionsPanel.transform);
        folderOptionsHolder.transform.position = new Vector3(folderOptionsHolder.transform.position.x, posY, 0);
        posY -= 70f;
    }
}
