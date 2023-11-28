using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager sharedInstance;
    //public GameObject starUnitPrefab;
    public GameObject playerPrefab;
    public GameObject trashPrefab;
    private List<GameObject> pooledObjects = new List<GameObject>();
    private int poolAmount = 21;
    public bool death = false;
    public bool potionSelected = false;
    public int pointCount = 0;
    public int coinCount = 100;

    public int starCount = 0;
    public int happiness = 100;
    public TMP_Text happyText;





    // Start is called before the first frame update

    private void Awake()
    {
        sharedInstance = this;
    }
    void Start()
    {

        for (int i = 0; i<poolAmount; i++)
        {
            Vector3 trashLoc = new Vector3(Random.Range(-9, 9), 0, Random.Range(-9, 9));
            GameObject trashObj = Instantiate(trashPrefab, trashLoc, Quaternion.identity);
            trashObj.SetActive(false);
            pooledObjects.Add(trashObj);

        }
        happyText.text = "Happiness " + happiness.ToString();


    }

    // Update is called once per frame
    void Update()
    {

        //StartCoroutine(Trash());
        if (death == true)
        { 
            SceneManager.LoadScene("GameOver");
        }
        if (happiness == 0)
        {
            death = true;
        }
        StartCoroutine(Death());
        happyText.text = "Happiness " + happiness.ToString();

    }

    public GameObject GetPooledObj()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
    public void HasPotionSelected()
    {
        if (potionSelected == false)
        {
            potionSelected = true;
        }
        else if (potionSelected == true)
        { potionSelected = false; }
    }



    IEnumerator Trash()
    {
        yield return new WaitForSeconds(3);
        int num  = Random.Range(0, pooledObjects.Count-1);
        for (int i =0; i<num; i++)
        {
            pooledObjects[i].SetActive(true);
        }

    }
    IEnumerator Death()
    {
        yield return new WaitForSeconds(10);

        happiness -= 10;
        yield return new WaitForSeconds(20);
    }



}
