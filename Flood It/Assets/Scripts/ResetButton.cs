using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButton : MonoBehaviour
{
    GameObject obect;
    GameObject m_text;
    // Start is called before the first frame update
    void Start()
    {
        m_text = GameObject.Find("Counter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        string tile = "PlayingTile";
        for (int i = 0; i < 64; i++)
        {
            if (i == 0)
            {
                obect = GameObject.Find(tile);
                obect.GetComponent<Color_Randomizer>().Restart();
            }
            else
            {
                string cont = tile + " (" + i.ToString() + ")";
                obect = GameObject.Find(cont);
                obect.GetComponent<Color_Randomizer>().Restart();
            }
        }
        m_text.GetComponent<Clicks_counter>().Restart();
    }
}
