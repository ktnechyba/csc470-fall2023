using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Animator : MonoBehaviour
{
    public Animator animator;

    PlayerController player1Control;
    bool walking = false;
    bool toRun = false;
    bool isIdle = false;
    //press o to run

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (player1Control.amountToMove.magnitude > 0)
        {
            animator.SetBool("isIdle", isIdle = false);
            animator.SetBool("walking", walking=true);
            if (Input.GetKeyDown(KeyCode.O))
            {
                animator.SetBool("walking", walking=false);
                animator.SetBool("toRun", toRun = false);
            }
            animator.SetBool("toRun", toRun = false);
        }
        else
        {
            animator.SetBool("isIdle", isIdle = true);
        }
        
        
    }
}
