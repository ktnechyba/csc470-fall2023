using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{

    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactionPointRadius = 0.5f;
    [SerializeField] private LayerMask _interactableMask;
    [SerializeField] private InteractionPrompt _interactionPromptUI;
    [SerializeField] private QuestInteraction _questInteractUI;
    [SerializeField] private NameInteract _nameInteractUI;

    private readonly Collider[] _collider = new Collider[3];
    [SerializeField] private int _numFound;


    private Iinteractable _interactable;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionPointRadius, _collider,
            _interactableMask);

        if (_numFound > 0)
        {
            _interactable = _collider[0].GetComponent<Iinteractable>();

            if (_interactable != null)
            {
                if (!_interactionPromptUI.PromptIsDisplayed && Input.GetKeyDown(KeyCode.T))
                {
                    _interactionPromptUI.PromptSetUp(_interactable.InteractionPrompt);
                }
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (_interactionPromptUI.PromptIsDisplayed)
                    {
                        _interactionPromptUI.PromptClose();
                    }
                    if (!_questInteractUI.QuestIsDisplayed)
                    {
                        _questInteractUI.QuestSetUp(_interactable.QuestInteraction);
                    }
                    if (!_nameInteractUI.NameIsDisplayed)
                    {
                        _nameInteractUI.NameSetUp(_interactable.NameInteract);
                    }
                }

                if (Input.GetKeyDown(KeyCode.Q))
                {
                    Debug.Log("q");
                    if (_questInteractUI.QuestIsDisplayed)
                    {
                        _questInteractUI.QuestClose();
                    }
                    if (_nameInteractUI.NameIsDisplayed)
                    {
                        _nameInteractUI.NameClose();
                    }

                }

                    //}
                //else if (Input.GetKeyDown(KeyCode.K))
                //{
                //    if (_interactionPromptUI.PromptIsDisplayed)
                //    {
                //        _interactionPromptUI.PromptClose();
                //    }
                //    //open something else up
                //    if (Input.GetKeyDown(KeyCode.Q))
                //    {

                //    }
                //    else if (Input.GetKeyDown(KeyCode.K))
                //    {
                //        //exchange flowers
                //    }
                //}
            }
        }
        else
        {
            if (_interactable != null)
            {
                _interactable = null;
            }
            if (_interactionPromptUI.PromptIsDisplayed)
            {
                _interactionPromptUI.PromptClose();
            }
        }
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionPoint.position,_interactionPointRadius);
    }
}
