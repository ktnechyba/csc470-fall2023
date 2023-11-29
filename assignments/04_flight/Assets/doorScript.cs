using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class doorScript : MonoBehaviour, Iinteractable
{
    public TMP_Text interactionText;
    [SerializeField] private string _doorPrompt;
    public string InteractionPrompt => _doorPrompt;

    public string QuestInteraction => throw new System.NotImplementedException();

    public string NameInteract => throw new System.NotImplementedException();

    public string CandyInteract => throw new System.NotImplementedException();

    public bool Interact(Interactor interactor)
    {
        if (GameManagerScript.SharedInstance.HasKey == true)
        {interactionText.text = "door opened";
            return true;
        }

        interactionText.text = "need key to open door";

        return true;
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
