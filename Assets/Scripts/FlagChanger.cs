using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlagChanger : MonoBehaviour
{
    [SerializeField] public Texture germanFlag, englandFlag;
    Texture flag;

    private void Start()
    {
        flag = gameObject.GetComponent<RawImage>().texture;
    }

    public void ChangeFlagOnClick()
    {
        if(flag == germanFlag)
        {
            flag = englandFlag;
        }
        else if(flag == englandFlag)
        {
            flag = germanFlag;
        }
    }
}
