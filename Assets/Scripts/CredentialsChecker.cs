using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CredentialsChecker : MonoBehaviour
{
    public Text IncorrectMsg;
    public Dropdown username;

    private void Start()
    {
        username = GameObject.Find("UsernameDropdown").GetComponent<Dropdown>();
    }

    public void LoginButtonfunctionality(InputField password)
    {
        string passToCheck = password.text;
        if (passToCheck == "123" && username.value == 0)
        {
            SceneManager.LoadScene(1);
            //Debug.Log("Correct Password!");
        }
        else
        {
            IncorrectMsg.text = "Incorrect Password!";
            password.text = "";
            //Debug.Log("InCorrect Password!\n Please Try Again!!");
        }
    }
    

}
