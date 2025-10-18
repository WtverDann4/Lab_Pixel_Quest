using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextlevel = "Geolevel_2";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
          private void OnTriggerEnter2D(Collider2D collision)
          {
        switch (collision.tag)
        {
            case "Death":
                {
                    string thislevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thislevel);

                    Debug.Log("Death");
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextlevel);
                    break;


                }




        }


    
}        
     }

       
