﻿using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FormScript : MonoBehaviour
{
    public TMP_InputField firstNameField;
    public TMP_InputField lastNameField;
    public TextMeshProUGUI welcomeText;
    List<string> greetings = new List<string>()
    {
        "Hello", "Welcome", "Hi", "Hey", "Sup", "Howdy", "Yo",
        "Good day", "Greetings", "Good Morrow", "What's happening",
        "Ahoy", "Salutations", "G'day", "Hey There", "Good day",
        "Nice to meet you", "Pleasure to meet you",
        "Good to see you", "Hiya", "Whaddup", "Hello there",
        "ello"
     };

    public void Greet()
    {
        int r = Random.Range(0, greetings.Count);
        string playerName = "";

        if (firstNameField == null )
        {
            return;
        }
        else
        {
            playerName = firstNameField.text;
        }


        if (lastNameField != null ) 
        {
            playerName += " " + lastNameField.text;
        }

        if (playerName == "")
        {
            welcomeText.text = "";
        }
        else
        {
            welcomeText.text = $"{greetings[r]} {playerName}!";
        }
    }
}
