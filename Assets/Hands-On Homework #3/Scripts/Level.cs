using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public string nextlevel = "Level_2";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

         private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Finish":


                SceneManager.LoadScene(nextlevel);
                break;


        }


    }
         



}