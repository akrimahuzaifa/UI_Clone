using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DetailButton : MonoBehaviour
{
    
    public void OnPinterClickOnDetailButton()
    {
        SceneManager.LoadScene(3);
    }
}
