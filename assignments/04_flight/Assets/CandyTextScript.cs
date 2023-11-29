using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CandyTextScript : MonoBehaviour
{
    public TMP_Text candyText;
    public TMP_Text nameText;
    public int totalCandy = 0;
    int candyNeeded;
    
    // Start is called before the first frame update
    void Start()
    {
       GameManagerScript.SharedInstance.HasKey = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (totalCandy <= 0 && GameManagerScript.SharedInstance.score == 0 && nameText.text == "Carla")
        {
            candyText.text = "I need candy to give you the key. (press q to exit)";
        }
        else if (GameManagerScript.SharedInstance.score > 0 && totalCandy <25)
        {
            totalCandy += GameManagerScript.SharedInstance.score;
            GameManagerScript.SharedInstance.score -= GameManagerScript.SharedInstance.score;
            GameManagerScript.SharedInstance.scoreText.text = GameManagerScript.SharedInstance.score.ToString();
            candyNeeded = 25 - totalCandy;
            candyText.text = "I need " + candyNeeded + " pieces of candy before I can give you the key. (press q to exit)";
        }
        else if (totalCandy >= 25 && GameManagerScript.SharedInstance.HasKey == false)
        {
            candyText.text = "Thanks for the candy. Here is the key. (press q to exit)";
            GameManagerScript.SharedInstance.HasKey = true;
        }
        else if (totalCandy >= 25 && GameManagerScript.SharedInstance.HasKey == true)
        {
            candyText.text = "I have enough candy. You already have the key. (press q to exit)";
        }

        else
        {
            Debug.Log("there's a problem");
        }
    }
}
