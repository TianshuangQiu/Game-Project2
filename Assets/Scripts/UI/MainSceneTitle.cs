using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneTitle : MonoBehaviour
{
    [SerializeField] private TextGenerator textGenerator;
    [SerializeField] private float charDisplaySeed;
    private Text messageText;
    // Start is called before the first frame update
    private void Awake()
    {
        messageText = transform.Find("TitleText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Start()
    {
        TextGenerator textGeneratorOne = textGenerator;
        textGeneratorOne.AddWriter(messageText, "Lights     Out", charDisplaySeed);
    }
}
