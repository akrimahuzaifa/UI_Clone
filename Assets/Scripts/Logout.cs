using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Logout : MonoBehaviour
{
    public void Logoutbuttonfunctionality()
    {
        SceneManager.LoadScene(0);
    }
}
