using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    // Start is called before the first frame update
    #region pre config
    public GameObject warn;
    public GameObject shoot;
    public GameObject player;
    #endregion

    #region local vars

    float countDown;
    float fireCD;
    bool waiting;
    float timePerShot;

    private Vector3 tsfm;
    private Vector3 helper;
    private Quaternion qt;
    #endregion

    void Start()
    {
        countDown = 0f;
        fireCD = 0f;
        waiting = false;
        timePerShot = 15;
    }

    // Update is called once per frame
    void Update()
    {
        if (!waiting)
        {
            countDown += Time.deltaTime;
        }
        else
        {
            fireCD += Time.deltaTime;
        }
        if (timePerShot - countDown < 2)
        {
            fadeIn();
        }
        if(countDown > timePerShot)
        {
            countDown = 0;
            tsfm = player.transform.position;
            tsfm.z = 1;
            qt = Quaternion.Euler(0, 0, Random.Range(-90, 90));
            Instantiate(warn,tsfm, qt);
            waiting = true;
            
            fireCD = 0;
        }
        if (fireCD > 2)
        {
            tsfm.z = -1.5f;
            Instantiate(shoot, tsfm, qt);
            var arr = (GameObject.FindGameObjectsWithTag("Laser"));
            if (arr.Length > 0) 
            {
                Rigidbody2D bd = arr[0].GetComponent<Rigidbody2D>();
                helper = qt.eulerAngles;
                Debug.Log("setting velocity" + helper);
                var dir = new Vector2(-Mathf.Cos(helper.z * Mathf.PI / 180 + Mathf.PI / 2),
                    -Mathf.Sin(helper.z * Mathf.PI / 180 + Mathf.PI / 2));
                bd.velocity = 18 * dir;
            }
            
            fireCD = 0;
            waiting = false;
            timePerShot = Random.Range(5, 15);
            fadeOut();
        }
    }

    void fadeIn()
    {
        var arr = GameObject.FindGameObjectsWithTag("UI");
        foreach (var x in arr) 
        {
            x.GetComponent<UIHandler>().fadeIn();
        }
    }

    void fadeOut()
    {
        var arr = GameObject.FindGameObjectsWithTag("UI");
        foreach (var x in arr)
        {
            x.GetComponent<UIHandler>().fadeOut();
        }
    }
}
