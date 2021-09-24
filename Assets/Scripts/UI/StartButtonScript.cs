using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartButtonScript : MonoBehaviour
{
    private Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = transform.GetComponent<Button>();
        btn.onClick.AddListener(startLevel);
    }

    // Update is called once per frame
    void startLevel()
    {
        SceneManager.LoadScene("Level1");
    }
}
