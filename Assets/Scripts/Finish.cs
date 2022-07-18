using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    string[] Rank = new string[2];
    int rank = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rank == 2)
        {
            for (int i = 0; i < Rank.Length; i++)
            {
                print(Rank[i]);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        

        print(other.gameObject.name);
        if (other.gameObject.GetComponent<PlayerController>())
        {
            
            Rank[rank] = other.gameObject.GetComponent<PlayerController>().PlayerName;
            rank++;
            print("Player Dance");
            other.gameObject.GetComponent<PlayerController>().animator.SetTrigger("Dance");
        }
        else if (other.gameObject.GetComponent<AIPlayerController>())
        {
            
            Rank[rank] = other.gameObject.GetComponent<AIPlayerController>().AIname;
            rank++;
            print("AI Dance");
            other.gameObject.GetComponent<AIPlayerController>().AIanimator.SetTrigger("Dance");
        }
        //
        //PauseGame();
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
    }
}
