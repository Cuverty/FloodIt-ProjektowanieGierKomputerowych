using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Controler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Main Menu", LoadSceneMode.Single);
        }
    }

    public bool checkIfAllColored()
    {
        string tile = "PlayingTile";
        Color color = GameObject.Find(tile).GetComponent<SpriteRenderer>().color;
        for(int i = 1; i < 64; i++)
        {
            tile = "PlayingTile (" + i + ")";
            Debug.Log("sprawdzany tile: " + tile);
            if (GameObject.Find(tile).GetComponent<SpriteRenderer>().color != color)
            {
                return false;
            }
        }
        return true;
    }
}
