using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{

    public void GetUserName(InputField username)
    {
        DataBase.username = username.text;
    }
}
