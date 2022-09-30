using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] characters;
    public Text nameText;
    public Text netWorthText;

    void Start()
    {
        int selectedCharacter = PlayerPrefs.GetInt("selectedCharacter");
        selectedCharacter = (selectedCharacter) % characters.Length;
        characters[selectedCharacter].SetActive(true);

        string netWorth = PlayerPrefs.GetString("netWorth");
        string name = PlayerPrefs.GetString("name");

        nameText.text = name;
        netWorthText.text = netWorth;
    }
}
