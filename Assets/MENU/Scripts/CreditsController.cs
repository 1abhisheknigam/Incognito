﻿// Team Cryptowolves: Cheng Hann Gan, Odell Mizrahi, Battulga Myagmarjav, Abhishek Nigam, Jimmy Spearman
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CreditsController : MonoBehaviour {
    Animator myAnim;
	// Use this for initialization
	void Start () {
        myAnim = GetComponent<Animator>();
        myAnim.enabled = true;
        setCreditText();
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponentInParent<Canvas>().enabled)
        {
            myAnim.enabled = true;            
        }
        else 
        {
            myAnim.enabled = false;
        }
	}

    void setCreditText()
    {
        GetComponent<Text>().text =
        "-INCOGNITO-\n" +
        "\nCredits\n" +
        "AI Programming\nCheng Hann Gan\nJimmy Spearman\n\n" +
        "Character Design\nAbhishek Nigam\nJimmy Spearman\n\n" +
        "Gameplay Programming\nCheng Hann Gan\nOdell Mizrahi\nAbhishek Nigam\nJimmy Spearman\n\n" +
        "Level Design\nCheng Hann Gan\nOdell Mizrahi\nTulga Myagmarjav\n\n" +
        "Sound Design\nCheng Hann Gan\nJimmy Spearman\n\n" +
        "UI Design\nTulga Myagmarjav\nAbhishek Nigam\n\n" +
        "External Resources\n" +
        "AI: RAIN AI\n" +
        "Camera: Unity stealth game tutorial\n" +
        "Character Models/ Animations: Mixamo\n" +
        "Office Environment Art: ProBuilder, Unity stealth game tutorial\n" +
        "Font: Pirulen\n" +
        "Image Effects: Unity standard assets\n" +
        "Skyboxes: Cerberus\n" +
		"Blood FX Pack: Robin Schmidt\n" +
		"Sci-Fi Arsenal: Kenneth \"Archanor\" Foldal Moe\n" +
		"Middle-East Environment: Manufactura K4\n" +
		"Sounds: Adam_N, Apple loops, InspectorJ, Phil25, pgi, senitiel, UncleSigmund\n" +
		"Music: \"Hunter\", \"Incognito\" by Avery Alexander -https://creativecommons.org/licenses/by-nc-sa/3.0/legalcode (unmodified)" + 
        "\n\n\n" +
        "COPYRIGHT: TEAM INCOGNITO\n" +
        "End\n";
    }
}
