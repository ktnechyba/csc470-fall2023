using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManagerScript : MonoBehaviour
{
    public static GameManagerScript SharedInstance;
    public GameObject dialoguePanel;
    

    public TMP_Text nameText;
    public TMP_Text dialogueText;
    public TMP_Text scoreText;
    public GameObject candyPrefab;
    public int score = 0;
    public GameObject villagerPrefab;



    // Start is called before the first frame update
    void Start()
    {
        SharedInstance = this;
        for (int can = 0; can<15; can++)
        {
            GameObject candyObj = Instantiate(candyPrefab, new Vector3(Random.Range(-10, 10), 0f, Random.Range(-10, 10)), Quaternion.identity);

        }
        for (int vill = 0; vill <4; vill++)
        {
            GameObject villagerObj = Instantiate(villagerPrefab, new Vector3(Random.Range(-10, 10), 0f, Random.Range(-10, 10)), Quaternion.identity);

        }

    }

    public void Launchdialogue(VillagerScript villager)
    {
        dialoguePanel.SetActive(true);
        nameText.text = villager.name;
        dialogueText.text = villager.utterances[0];
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
}
