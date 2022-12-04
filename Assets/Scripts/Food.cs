using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    public float speed = 2f;


    // Start is called before the first frame update
    void Start()
    {

    }

    //Moves this GameObject 2 units a second in the forward direction
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

}
