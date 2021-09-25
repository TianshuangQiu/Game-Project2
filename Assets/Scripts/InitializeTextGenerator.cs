using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializeTextGenerator : MonoBehaviour
{
    [SerializeField] private TextGenerator textGenerator;
    [SerializeField] private string textToDisplay; 
    [SerializeField] private float charDisplaySeed;
    private Text messageText;
    private void Awake()
    {
        messageText = gameObject.GetComponent<Text>();
    }

    void Start()
    {
        Debug.Log("New Game Object");
        textGenerator.AddWriter(messageText, textToDisplay, charDisplaySeed);
    }
}
