using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManger : MonoBehaviour
{
    [SerializeField] private GameObject prompterText;


    public void OpenPrompter()
    {
        Debug.Log("Button is pushed");
        prompterText.SetActive(true);
    }
}
