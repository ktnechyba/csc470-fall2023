using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTriggerManager : MonoBehaviour
{
    [SerializeField] private GameObject CheckPanel;
    private bool triggered = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShopCheck();
            ShopTextManager.instanceText.CoinExchange();
            GameObject.FindWithTag("Player").GetComponent<PlayerControllerTown>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    private void ShopCheck()
    {
        if (triggered == false)
        {
            CheckPanel.SetActive(true);
            triggered = true;
        }
    }
    public void IsNotTriggered()
    {
        if (triggered == true)
        {
            triggered = false;
        }
    }
    
}
