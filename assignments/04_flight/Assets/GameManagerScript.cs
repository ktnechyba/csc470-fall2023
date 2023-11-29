using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript SharedInstance;
    public GameObject dialoguePanel;
    private new Vector3 pos;

    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public TMP_Text scoreText;
    public TMP_Text scoreCoinText;
    public TMP_Text scoreFuelText;

    public GameObject candyPrefab;

    public int score = 0;
    public int scoreCoins = 0;
    public int scorefuel = 100;
    public GameObject fuelPrefab;
    public GameObject ringPrefab;
    public GameObject coinPrefab;
    public GameObject wall2;
    public bool HasKey=false;



    // Start is called before the first frame update
    void Start()
    {
        SharedInstance = this;
        for (int can = 0; can<65; can++)
        {
            GameObject candyObj = Instantiate(candyPrefab, new Vector3(Random.Range(-7, 7), 0f, Random.Range(-7, 7)), Quaternion.identity);
        }
        //for (int sky = 0; sky < 65; sky++)
        //{
        //    GameObject ringObj = Instantiate(ringPrefab, new Vector3(Random.Range(-150,50), 15f, Random.Range(-150, 50)), Quaternion.identity);
        //    GameObject fuelObj = Instantiate(fuelPrefab, new Vector3(Random.Range(-150, 50), 15f, Random.Range(-150, 50)), Quaternion.identity);
        //}


    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int howMuch)
    {
        score += howMuch;
        scoreText.text = score.ToString();
    }
    public void UpdateCoins(int howMuch)
    {
        scoreCoins += howMuch;
        scoreCoinText.text = scoreCoins.ToString();
    }
    public void RainCoins(int howMuch)
    {
        Vector3 pos = GameObject.Find("carpet").GetComponent<Transform>().position;
        for (int sky = 0; sky < howMuch; sky++)
        {
            GameObject coinObj = Instantiate(coinPrefab, pos*5, Quaternion.identity);

        }
    }
        public void MinusFuel(int howMuch)
    {
        scorefuel -= howMuch;
        scoreFuelText.text = scoreCoins.ToString();
    }
    public void AddFuel(int howMuch)
    {
        scorefuel += howMuch;
        scoreFuelText.text = scoreCoins.ToString();
    }
}
