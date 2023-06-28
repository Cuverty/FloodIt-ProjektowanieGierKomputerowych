using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clicks_counter : MonoBehaviour
{
    int counter;
    TMP_Text m_TextComponent;
    string text;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
        m_TextComponent = GetComponent<TextMeshProUGUI>();
        m_TextComponent.text = "0/25";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Add()
    {
        counter++;
        text = counter.ToString() + "/25";
        m_TextComponent.text = text;
        return;
    }

    public void Restart()
    {
        counter = 0;
        text = counter.ToString() + "/25";
        m_TextComponent.text = text;
        return;
    }

    public int getCounterNumber()
    {
        return counter;
    }
}
