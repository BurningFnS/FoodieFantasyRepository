using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    IEnumerator isGameRunning; //This variable can change name. It is necessary to "pause" the loop because if u directly pause it, it will start from initial.

    // Start is called before the first frame update
    void Start()
    {
        isGameRunning = GameLoop();
        StartCoroutine(isGameRunning);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("Game Loop Has been resumed");
            StartCoroutine(isGameRunning);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Game Loop Has been paused");
            StopCoroutine(isGameRunning);
        }   
    }

    IEnumerator GameLoop()
    {
        while (true)
        {
            //This for loop is just to test if the pause/resume button works
            for(int i = 0; i < 10000; i++)
            {
                Debug.Log(i);
                yield return new WaitForSeconds(0.5f);
            }

        }
    }
}
