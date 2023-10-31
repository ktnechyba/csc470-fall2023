using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CandyInteract : MonoBehaviour
{
    [SerializeField] private GameObject _candyPanel;
    [SerializeField] private TextMeshProUGUI _candyText;
    public bool CandyDisplayed = false;
    // Start is called before the first frame update
    void Start()
    {
        _candyPanel.SetActive(false);
    }

    public void CandySetUp(string candyText)
    {
        _candyText.text = candyText;
        _candyPanel.SetActive(true);
        CandyDisplayed = true;
    }
    public void CandyClose()
    {
        _candyPanel.SetActive(false);
        CandyDisplayed = false;
    }
}
