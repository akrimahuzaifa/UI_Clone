using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainInstantiator : MonoBehaviour
{
    public GameObject enginePrefab;
    public GameObject bogiPrefab;
    public GameObject trainPanel;
    [HideInInspector] public GameObject trainHolder;
    List<GameObject> trainList = new List<GameObject>();

    public float posX = 94.5f + 115f;
    float posY = 579.6f + 90f;
    
    private void Start()
    {
        if (DataBase.trainCount != 0)
        {
            for (int i = 0; i < DataBase.trainCount; i++)
            {
                ValuesFromDatabaseTrain();
            }
        }
    }

    public void OnClickInstantiatorAddTrain()
    {
        ValuesFromDatabaseTrain();
        DataBase.trainCount++;
    }
    public void ValuesFromDatabaseTrain()
    {
        if(trainPanel.transform.childCount < 1)
        {
            trainHolder = Instantiate(enginePrefab, trainPanel.transform);
            trainHolder.transform.position = new Vector3(posX, posY, 0);
            //trainList.Add(Instantiate(enginePrefab, trainPanel.transform));
            //trainList[0].transform.position = new Vector3(posX + 10f, posY, 0);
            //Debug.Log(trainList[0].transform.position);
            posX += 300f;
        }
        else
        {
            trainHolder = Instantiate(bogiPrefab, trainPanel.transform);
            trainHolder.transform.position = new Vector3(posX, posY, 0);
            /*            trainList.Add(Instantiate(bogiPrefab, trainPanel.transform));

                        for (int i = 1; i < trainList.Count; i++)
                        {

                            trainList[i].transform.position = new Vector3(posX, posY, 0);

                            //Debug.Log(trainList[0].transform.position);
                        }*/
            posX += 300f;

        }
        
    }
}
