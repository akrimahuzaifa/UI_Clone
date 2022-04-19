using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainDestroyer : MonoBehaviour
{
    GameObject trainPanel;
    GameObject lastChildObj;

    void Start()
    {
        trainPanel = FindObjectOfType<TrainInstantiator>().trainPanel;
    }

    public void DestroyLastAddedTrain()
    {
        if(trainPanel.transform.childCount > 0)
        {
            int lastChildIndex = trainPanel.transform.childCount - 1;
            lastChildObj = trainPanel.transform.GetChild(lastChildIndex).gameObject;
            Destroy(lastChildObj);
            FindObjectOfType<TrainInstantiator>().posX -= 300f;
            DataBase.trainCount--;
        }
    }
 
}
