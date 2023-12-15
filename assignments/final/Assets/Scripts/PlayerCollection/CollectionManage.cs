using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionManage : MonoBehaviour
{
    public GameObject magic;
    public GameObject swordsman;

    private void Awake()
    {
        if (CharacterSelect.shared_instance.mage == true)
        {
            magic.SetActive(true);
        }
        if (CharacterSelect.shared_instance.sword == true)
        {
            swordsman.SetActive(true);
        }
    }

}
