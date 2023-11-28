using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTriggerManager : MonoBehaviour
{
    [SerializeField] private GameObject NPCPanel;
    [SerializeField] private GameObject ShopPanel;
    [SerializeField] private GameObject CheckPanel;
    public bool triggered = false;

    public void OpenShop()
    {
        NPCPanel.SetActive(true);
        ShopPanel.SetActive(true);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ShopCheck();
            ShopTextManager.instanceText.PotionShop();
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
