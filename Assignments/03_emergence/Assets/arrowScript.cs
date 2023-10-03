using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowScript : MonoBehaviour
{
    public manageGame gameManage;
    public deadBalloonScript deadB;
    public aliveBalloonScript aliveB;

    // Start is called before the first frame update
    void Start()
    {
        GameObject gameManageObj = GameObject.FindWithTag("manager");
        gameManage = gameManageObj.GetComponent<manageGame>();
        GameObject aBalloon = GameObject.FindWithTag("score");
        aliveB = aBalloon.GetComponent<aliveBalloonScript>();
        GameObject dBalloon = GameObject.FindWithTag("minus");
        deadB = dBalloon.GetComponent<deadBalloonScript>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("score"))
        {
            gameManage.incScore(1);


        }
        if (other.CompareTag("minus"))
        {
            gameManage.decrScore(1);

        }
    }

}
