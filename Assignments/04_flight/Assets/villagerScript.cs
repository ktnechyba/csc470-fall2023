using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VillagerScript : MonoBehaviour, Iinteractable
{
    public string[] utterances;
    [SerializeField] private string _prompt;
    [SerializeField] private string _quest;
    [SerializeField] private string _name;

    string Iinteractable.InteractionPrompt => _prompt;
    string Iinteractable.QuestInteraction => _quest;
    string Iinteractable.NameInteract => _name;

    bool Iinteractable.Interact(Interactor interactor)
    {
        Debug.Log("villager");
        return true;
    }

    // Start is called before the first frame update
    void Start()
    {
        transform.Rotate(0, Random.Range(0, 360), 0, Space.Self); 
    }

    // Update is called once per frame
    void Update()
    {
    }
}
