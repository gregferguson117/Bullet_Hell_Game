﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class select_ship : MonoBehaviour
{
    public static int selected_ship;
    public TMP_Text system_message;
    public Button first;
    public Button second;

    private Color signature_color;
    // Start is called before the first frame update
    void Start()
    {
        //Initially select first ship displayed
        selected_ship = 0;
        signature_color = new Color(0f, 255f, 255f, 255f);
        system_message.SetText("fancy name for blue ship");
        first.image.color = signature_color;
        second.image.color = Color.gray;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void first_ship_selected()
    {
        selected_ship = 0;
        system_message.SetText("Fancy name for blue ship");
        first.image.color = signature_color;
        second.image.color = Color.grey;
    }
    public void second_ship_selected()
    {
        selected_ship = 1;
        system_message.SetText("Fancy name for another ship");
        second.image.color = signature_color;
        first.image.color = Color.grey;
    }

    public void on_play_click()
    {
        //Load next scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
    }

}
