using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Iinteractable
{
    public string InteractionPrompt { get; }
    public string QuestInteraction { get; }
    public string NameInteract { get; }

    public bool Interact(Interactor interactor);

}
