using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CharacterSelection : MonoBehaviour
{
    public GameObject[] characters;
    public Text nameText;
    public Text networthText;
    public int selectedCharacter = 0;
    public string netWorth;
    public string name;


    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;
        if (selectedCharacter < 0)
        {
            selectedCharacter += characters.Length;
        }
        characters[selectedCharacter].SetActive(true);
    }

    public void StartGame()
    {
        name = nameText.text;
        netWorth = "Net Worth: $" + networthText.text;
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        PlayerPrefs.SetString("netWorth", netWorth);
        PlayerPrefs.SetString("name", name);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
}
