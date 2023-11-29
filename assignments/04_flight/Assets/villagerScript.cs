using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerScript : MonoBehaviour, Iinteractable
{
    [SerializeField] private string _prompt;
    [SerializeField] private string _quest;
    [SerializeField] private string _name;
    [SerializeField] private string _candy;
    string Iinteractable.InteractionPrompt => _prompt;
    string Iinteractable.QuestInteraction => _quest;
    string Iinteractable.NameInteract => _name;
    string Iinteractable.CandyInteract => _candy;

    bool Iinteractable.Interact(Interactor interactor)
    {
        Debug.Log("villager");
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
