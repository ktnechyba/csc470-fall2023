using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractionPrompt : MonoBehaviour
{
    [SerializeField] private GameObject _promptPanel;
    [SerializeField] private TextMeshProUGUI _promptText;
    public bool PromptIsDisplayed = false;


    // Start is called before the first frame update
    void Start()
    {
        _promptPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PromptSetUp(string promptText)
    {
        _promptText.text = promptText;
        _promptPanel.SetActive(true);
        PromptIsDisplayed = true;
    }
    public void PromptClose()
    {
        _promptPanel.SetActive(false);
        PromptIsDisplayed = false;
    }



}
