using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayAnim : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(anim());
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator anim()
    {
        while (true)
        {
            animator.Play("Base Layer.Idle");
            float delay = Random.Range(1.0f, 5.0f);
            Debug.Log(delay);
            yield return new WaitForSeconds(delay);
        }
    }
}
