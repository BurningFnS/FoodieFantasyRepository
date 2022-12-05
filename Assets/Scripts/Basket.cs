using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    public GameManager gamemanager;

    public Image Lose;

    private List<string> ItemList = new List<string>();
    private List<string> JunkList = new List<string>();
    private List<string> BadItemsList = new List<string>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Food")
        {
            ItemList.Add(gameObject.name);
            Debug.Log("ItemList Count: " + ItemList.Count);
            Destroy(other.gameObject);

            if(ItemList.Count > 15)
            {
                Debug.Log("You have severely overbought. Please KYS");
                Lose.gameObject.SetActive(true);
                gamemanager.endGame = true;
            }
        }

        if (other.gameObject.tag == "Junk")
        {
            JunkList.Add(gameObject.name);
            Debug.Log("JunkList Count: " + JunkList.Count);
            Destroy(other.gameObject);

            if (JunkList.Count > 1)
            {
                Debug.Log("Fatty");
                Lose.gameObject.SetActive(true);
                gamemanager.endGame = true;

            }
        }

        if (other.gameObject.tag == "Inedible")
        {
            
            BadItemsList.Add(gameObject.name);
            Debug.Log("BadItemsList Count: " + BadItemsList.Count);
            Destroy(other.gameObject);

            if (BadItemsList.Count >= 3)
            {
                Debug.Log("-1 point");

            }
        }
    }

}

