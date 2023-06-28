using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class clickAction : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    GameObject start, m_text, m_control;
    Color color;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        color = spriteRenderer.color;
        start = GameObject.Find("PlayingTile");
        m_text = GameObject.Find("Counter");
        m_control = GameObject.Find("Control");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnMouseDown is called when mouse clicks on a collider
    void OnMouseDown()
    {
        if(m_text.GetComponent<Clicks_counter>().getCounterNumber() < 25)
        {
            start.GetComponent<Color_Randomizer>().ChangeColor(color);
            m_text.GetComponent<Clicks_counter>().Add();
            if (m_control.GetComponent<Controler>().checkIfAllColored() == true)
            {
                SceneManager.LoadScene("Win", LoadSceneMode.Single);
            }
        }
        else
        {
            SceneManager.LoadScene("Lose", LoadSceneMode.Single);
        }
    }
}
