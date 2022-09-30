using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class reminders : MonoBehaviour
{
    public Button homeButton;
    public Text reminderText;
    public int i = 0;
    public List<string> reminderList = new List<string> 
    {
        "Maybe your opponent's just having a good day.", 
        "Happy winning wargames Wednesday.", 
        "Kill yourself.",
        "Remember to drink water.", 
        "Have you meditated today?",
        "Got Milk?"
    };

    void Start()
    {
        newReminder();
    }
    public void newReminder() 
    {
        if(i > reminderList.Count - 1) 
        {
            i = 0;
        }
        reminderText.text = reminderList[i];
        i++;
    }
}
