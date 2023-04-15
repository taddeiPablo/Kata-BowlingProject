using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ViewGame : MonoBehaviour
{
    private TMP_InputField _inputField;

    private Button _shootButton;
    private ShootButton _shootButtonScript;

    private void Start()
    {
        _shootButtonScript = _shootButton.GetComponent<ShootButton>();
        _shootButtonScript.OnShoot += ValidateValues;

    }

    private void ValidateValues()
    {
        bool haveText = _inputField.text.Length > 0;
        bool correctString = _inputField.text.Contains(",");

        bool correctNumbers;
        string[] values = _inputField.text.Split(',');

        int[] numbers = new int[10];


        for (int i = 0; i < values.Length; i++)
        {
            int n;
            correctNumbers = int.TryParse(values[i], out n);

            if (correctNumbers)
            {
                numbers[i] = n;
            }
            else
            {
                break;
            }
        }
        
        
        
        
    }

    private void OnDisable()
    {
        _shootButtonScript.OnShoot -= ValidateValues;
    }
}
