using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{


    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        Transform a = game.transform;
        Debug.Log(a.position);
        var x = a.position.x;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
