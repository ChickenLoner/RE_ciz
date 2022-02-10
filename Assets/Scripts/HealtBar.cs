using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealtBar : MonoBehaviour
{
    private Image Health_bar;
    public float CurrentHealth;
    private float MaxHealth = 100f;
    Playercontrol player;
    void Start()
    {
        Health_bar = GetComponent<Image>();
        player = FindObjectOfType<Playercontrol>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentHealth = player.Health;
        Health_bar.fillAmount = CurrentHealth/MaxHealth;
    }
}
