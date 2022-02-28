using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        print(other.gameObject.name);
        PauseGame();
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }
}
