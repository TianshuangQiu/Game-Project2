using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wipe : MonoBehaviour
{
    private float myTime;
    // Start is called before the first frame update
    void Start()
    {
        myTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        myTime += Time.deltaTime;
        if(myTime > 2)
        {
            Destroy(this.gameObject);
        }
    }
}
