using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Button = UnityEngine.UI.Button;
using System.Diagnostics;


public class Button : MonoBehaviour
{

   [SerializeField] private UnityEngine.UI.Button m_YourFirstButton;
   

    private void OnEnable()
    {



        m_YourFirstButton.onClick.AddListener(TaskOnClick);
    }


    private void TaskOnClick()
    {
        UnityEngine.Debug.Log("Click!");

    }





}
