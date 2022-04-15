using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResetInputField : MonoBehaviour
{
    [SerializeField] Dropdown accessAs; 
    public void ClearPassword(InputField password)
    {
        password.text = "";
    }
    public void ResetDropDown(Dropdown value)
    {
        value.value = 0;
        Debug.Log(value);
        //GameObject.Find("TrainerLabel").GetComponent<Text>().text;
    }
}
