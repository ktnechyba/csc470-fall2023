using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShopTextManager : MonoBehaviour
{
    public static ShopTextManager instanceText;
    [SerializeField] private TextMeshProUGUI npcNameText;
    [SerializeField] private TextMeshProUGUI npcTalkText;
    [SerializeField] private TextMeshProUGUI shopHeaderText;
    [SerializeField] private TextMeshProUGUI shopButtontext;
    private void Awake()
    {
        instanceText = this;
    }
    public void PotionShop()
    {
        npcTalkText.text = "Want any potions?";
        npcNameText.text = "Janna";
        shopHeaderText.text = "Stars for Potions";
        shopButtontext.text = "1 for 3";
    }

    public void CoinExchange()
    {
        npcTalkText.text = "Want any stars?";
        npcNameText.text = "Vinny";
        shopHeaderText.text = "Coins for Stars";
        shopButtontext.text = "1 for 3";
    }


}
