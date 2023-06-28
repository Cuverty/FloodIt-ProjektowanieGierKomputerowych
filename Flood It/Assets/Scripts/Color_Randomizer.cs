using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Randomizer : MonoBehaviour
{
    Color[] colorDB = { new Color(0.0f, 0.0f, 1.0f), new Color(1.0f, 0.0f, 0.0f), new Color(9.0f/255.0f, 196.0f/255.0f, 43.0f/255.0f), new Color(160.0f/255.0f, 32.0f/255.0f, 240.0f/255.0f), new Color(1.0f, 1.0f, 0.0f), new Color(1.0f, 165.0f/255.0f, 0.0f)};
    SpriteRenderer spriteRenderer;
    Color_Randomizer right = null, left = null, up = null, down = null;
    RaycastHit hit;
    float distanceBetweenTiles = 100.0f;
    bool changed = false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        int x = Random.Range(0, 6);
        Debug.Log(gameObject.name + ": " + x);
        spriteRenderer.color = colorDB[x];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Physics.Raycast(transform.position, Vector3.right, out hit, distanceBetweenTiles))
        {
            if (hit.collider && !right)
            {
                right = hit.collider.gameObject.GetComponent<Color_Randomizer>();
            }
        }
        if (Physics.Raycast(transform.position, Vector3.left, out hit, distanceBetweenTiles))
        {
            if (hit.collider && !left)
            {
                left = hit.collider.gameObject.GetComponent<Color_Randomizer>();
            }
        }
        if (Physics.Raycast(transform.position, Vector3.down, out hit, distanceBetweenTiles))
        {
            if (hit.collider && !down)
            {
                down = hit.collider.gameObject.GetComponent<Color_Randomizer>();
            }
        }
        if (Physics.Raycast(transform.position, Vector3.up, out hit, distanceBetweenTiles))
        {
            if (hit.collider && !up)
            {
                up = hit.collider.gameObject.GetComponent<Color_Randomizer>();
            }
        }
    }

    // ChangeColor is called by another GameObject when this GameObject should change color to color of another GameObject
    public void ChangeColor(Color color, Color original)
    {
        if(spriteRenderer.color != original)
        {
            return;
        }

        spriteRenderer.color = color;
        changed = true;

        if (right && !right.changed)
        {
            right.ChangeColor(spriteRenderer.color, original);
        }
        if (left && !left.changed)
        {
            left.ChangeColor(spriteRenderer.color, original);
        }
        if (down && !down.changed)
        {
            down.ChangeColor(spriteRenderer.color, original);
        }
        if (up && !up.changed)
        {
            up.ChangeColor(spriteRenderer.color, original);
        }

        changed = false;
    }

    public void ChangeColor(Color color)
    {
        Color original = spriteRenderer.color;
        spriteRenderer.color = color;
        changed = true;

        if (right && !right.changed)
        {
            right.ChangeColor(spriteRenderer.color, original);
        }
        if (left && !left.changed)
        {
            left.ChangeColor(spriteRenderer.color, original);
        }
        if (down && !down.changed)
        {
            down.ChangeColor(spriteRenderer.color, original);
        }
        if (up && !up.changed)
        {
            up.ChangeColor(spriteRenderer.color, original);
        }

        changed = false;
    }

    public void Restart()
    {
        int x = Random.Range(0, 5);
        spriteRenderer.color = colorDB[x];
    }
}
