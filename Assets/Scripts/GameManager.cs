using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vector3 startingLine;
    [SerializeField]
    private GameObject[] groceriesList;
    private GameObject grocery;

    IEnumerator isGameRunning; //This variable can change name. It is necessary to "pause" the loop because if u directly pause it, it will start from initial.

    void Awake()
    {
        startingLine = new Vector3(Random.Range(-2.15f, 2.15f), 5.8f, 0f);
    }

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
        startingLine = new Vector3(Random.Range(-2.15f, 2.15f), 5.8f, 0f);
    }

    IEnumerator GameLoop()
    {
        while (true)
        {
            Instantiate(groceriesList[Random.Range(0, groceriesList.Length)], startingLine, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }

    private GameObject GetRandomGrocery()
    {
        return groceriesList[Random.Range(0, groceriesList.Length)];
    }
}
