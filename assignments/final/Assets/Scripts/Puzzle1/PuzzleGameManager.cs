using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleGameManager : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        animator.SetBool("P1", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
