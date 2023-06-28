using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingArray : MonoBehaviour
{
    GameObject[,] map;
    GameObject tile = new GameObject("", typeof(SpriteRenderer), typeof(BoxCollider), typeof(Color_Randomizer));

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
