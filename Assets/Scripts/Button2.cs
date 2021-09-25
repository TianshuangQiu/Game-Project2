using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Button2 : MonoBehaviour
{
    void Start()
    {
        Button btn = transform.GetComponent<Button>();
        btn.onClick.AddListener(startLevel);
    }

    void startLevel()
    {
        SceneManager.LoadScene("Intro");
    }
}
