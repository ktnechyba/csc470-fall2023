using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameInteract : MonoBehaviour
{
    [SerializeField] private GameObject _namePanel;
    [SerializeField] private TextMeshProUGUI _nameText;
    public bool NameIsDisplayed = false;
    // Start is called before the first frame update
    void Start()
    {
        _namePanel.SetActive(false);
    }

    public void NameSetUp(string nameText)
    {
        _nameText.text = nameText;
        _namePanel.SetActive(true);
        NameIsDisplayed = true;
    }
    public void NameClose()
    {
        _namePanel.SetActive(false);
        NameIsDisplayed = false;
    }
}
