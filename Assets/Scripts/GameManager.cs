using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vector3 startingLine;
    IEnumerator isGameRunning; //This variable can change name. It is necessary to "pause" the loop because if u directly pause it, it will start from initial.
    [SerializeField]
    private GameObject[] groceriesList;
    [SerializeField]
    private GameObject[] junkList;
    [SerializeField]
    private GameObject[] baditemList;

    [HideInInspector]
    public bool endGame = false;


    void Awake()
    {
        startingLine = new Vector3(Random.Range(-2.2f, 2.2f), 5.7f, 0f);
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
        startingLine = new Vector3(Random.Range(-2.2f, 2.2f), 5.7f, 0f);

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
        while (endGame == false)
        {
            Instantiate(groceriesList[Random.Range(0, groceriesList.Length)], startingLine, Quaternion.identity);
            yield return new WaitForSeconds(1.7f); // DELAY FOR EACH INSTANTIATE 

            Instantiate(junkList[Random.Range(0, junkList.Length)], startingLine, Quaternion.identity);
            yield return new WaitForSeconds(2.3f); // DELAY FOR EACH INSTANTIATE 

            Instantiate(baditemList[Random.Range(0, baditemList.Length)], startingLine, Quaternion.identity);
            yield return new WaitForSeconds(2.3f); // DELAY FOR EACH INSTANTIATE 

        }
    }
}
