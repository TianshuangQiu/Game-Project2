using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSceneTitle : MonoBehaviour
{
    [SerializeField] private TextGenerator textGenerator;
    [SerializeField] private float charDisplaySpeed;
    private Text titleText;
    private Text startText;
    private bool created = false;
    private void Awake()
    {
        titleText = transform.Find("TitleText").GetComponent<Text>();
        startText = transform.Find("StartButton").Find("StartText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "MainScene")
        {
            textGenerator.AddWriter(titleText, "Lights     Out", charDisplaySpeed);
            textGenerator.AddWriter(startText, "Start", charDisplaySpeed);
        } else if (scene.name == "VictoryScene")
        {
            textGenerator.AddWriter(titleText, "Congratulations!!!", charDisplaySpeed);
            textGenerator.AddWriter(startText, "Start   again", charDisplaySpeed);
        } else if (scene.name == "DeadScene")
        {
            textGenerator.AddWriter(titleText, "You     lost...", charDisplaySpeed);
            textGenerator.AddWriter(startText, "Try again", charDisplaySpeed);
        }
    }
}
