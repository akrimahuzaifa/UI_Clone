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
    [SerializeField] InputField inputFieldToHold;

    public float posX = 94.5f + 115f;
    float posY = 579.6f + 90f;
    public static float diff = 250f;
    
    private void Start()
    {
        if (DataBase.trainCount != 0)
        {
            for (int i = 0; i < DataBase.trainCount; i++)
            {
                ValuesFromDatabaseTrain();
            }
        }
        if (DataBase.username != null)
        {
            inputFieldToHold.text = DataBase.username;
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
            posX += diff;
        }
        else
        {
            trainHolder = Instantiate(bogiPrefab, trainPanel.transform);
            trainHolder.transform.position = new Vector3(posX, posY, 0);
            posX += diff;
        }  
    }
}
