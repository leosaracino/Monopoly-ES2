using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript : MonoBehaviour
{
    Text text;

    void Start()
    {
        text = GetComponent<Text>();
    }

    private void OnEnable()
    {
        DiceCheckZone.onAllDicesStop += UpdateText;
    }

    private void OnDisable()
    {
        DiceCheckZone.onAllDicesStop -= UpdateText;
    }

    void UpdateText(int diceSum)
    {
        text.text = $"Valor: {diceSum}";
    }
}
