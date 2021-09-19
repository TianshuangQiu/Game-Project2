using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public Image img;
    // Start is called before the first frame update

    private void Start()
    {
        img.CrossFadeAlpha(0f, 0.01f, false);
    }
    public void fadeIn()
    {
        img.CrossFadeAlpha(0.5f, 1, false);
    }

    public void fadeOut()
    {
        img.CrossFadeAlpha(0, 1, false);
    }
}
