using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    InputController inputController;
    bool waitState = true;
    public GameObject cube;

    void Start()
    {
        //This will do the network stuff
        inputController = new InputController();
        inputController.Begin("192.168.43.188", 80);

    }

    void Update()
    {
        

    }

}