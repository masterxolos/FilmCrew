using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextManger : MonoBehaviour
{
    [SerializeField] private GameObject prompterText;
    [SerializeField] private GameObject nextBubbleText;
    [SerializeField] private GameObject[] buttonText = new GameObject[2];
    
    

    [SerializeField] private GameObject instructionsText;

    [SerializeField] private Animator adamAnimator;


    [SerializeField] private int instructionYaziSuresi;
    [SerializeField] private int bubbleYaziCıkmaSuresi;
     public void OpenPrompter()
    {
        Debug.Log("Button is pushed");
        prompterText.SetActive(true);
        for (int i = 0; i < buttonText.Length; i++)
        {
            buttonText[i].SetActive(false);
        }
        nextBubbleText.SetActive(true);
        adamAnimator.SetBool("kızgın",true);
    }


    private void Start()
    {
        StartCoroutine(DissappearInstructions());
        StartCoroutine(WaitForBubbleText());
    }

    private IEnumerator WaitForBubbleText()
    {
        yield return new WaitForSeconds(bubbleYaziCıkmaSuresi);
        for (int i = 0; i < buttonText.Length; i++)
        {
            buttonText[i].transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    private IEnumerator DissappearInstructions()
    {
        yield return new WaitForSeconds(instructionYaziSuresi);
        instructionsText.SetActive(false);
    }
        
}
