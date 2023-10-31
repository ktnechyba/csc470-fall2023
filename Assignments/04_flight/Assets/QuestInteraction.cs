using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestInteraction : MonoBehaviour
{
    [SerializeField] private GameObject _questionPanel;
    [SerializeField] private TextMeshProUGUI _questionText;
    public bool QuestIsDisplayed = false;
    // Start is called before the first frame update
    void Start()
    {
        _questionPanel.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuestSetUp(string questText)
    {
        _questionText.text = questText;
        _questionPanel.SetActive(true);
        QuestIsDisplayed = true;
    }
    public void QuestClose()
    {
        _questionPanel.SetActive(false);
        QuestIsDisplayed = false;
    }


}
