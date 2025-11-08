using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStats : MonoBehaviour
{
    public string nextlevel = "Geolevel_2";
    private int coinCounter = 0;
    private int _health = 0;
    private int _maxhealth = 3;
    public Transform respawnPoint;

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
                    _health++;
                    if (_health <= 0)
                    {
                        string thisLevel = SceneManager.GetActiveScene().name;
                    }
                    else
                    {
                        transform.position = respawnPoint.position;
                        break;

                    }

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
            case "Coin":
                {
                    coinCounter++;
                    Destroy(collision.gameObject);
                    break;


                }
            case "Health":
                {
                    if(_health < _maxhealth)
                    {
                        Destroy(collision.gameObject);
                        _health++;

                    }
                    break;


                }
              


            





        }


    
}        
     }

       
