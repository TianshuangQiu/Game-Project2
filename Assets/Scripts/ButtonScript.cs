using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btn = transform.GetComponent<Button>();
        btn.onClick.AddListener(startLevel);
    }

    void startLevel()
    {
        SceneManager.LoadScene("Level1");
    }
}
