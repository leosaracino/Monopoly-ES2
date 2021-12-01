using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceCheckZone : MonoBehaviour
{
    public static Action<int> onAllDicesStop = null;

    [SerializeField]
    Dice[] dices = null;

    int stoppedDices = 0;

    private void OnEnable()
    {
        stoppedDices = 0;
        foreach (Dice dice in dices)
        {
            dice.onStop += IncrementStoppedDices;
        }
    }

    private void OnDisable()
    {
        foreach (Dice dice in dices)
        {
            dice.onStop -= IncrementStoppedDices;
        }
    }

    private void IncrementStoppedDices()
    {
        stoppedDices++;
        if (stoppedDices == dices.Length)
        {
            int sumOfAllDices = 0;
            foreach (Dice dice in dices)
            {
                sumOfAllDices += dice.GetDiceValue();
            }
            onAllDicesStop?.Invoke(sumOfAllDices);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            foreach (Dice dice in dices)
            {
                dice.Reset();
            }
            stoppedDices = 0;
            onAllDicesStop?.Invoke(0);
        }
    }
}
