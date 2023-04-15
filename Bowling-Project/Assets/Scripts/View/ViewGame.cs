using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using View;

public class ViewGame : MonoBehaviour, IView
{
    [SerializeField]private TMP_InputField _inputField;
    [SerializeField]private TextMeshProUGUI _errorText;
    [SerializeField] private GameObject InputUI;

    [SerializeField] private Ball ball;

    private GamePresenter _gamePresenter;

    [SerializeField] private GameObject totalScoreObj;
    [SerializeField] private TextMeshProUGUI totalScoreText;
    
    private void Start()
    {
        _gamePresenter = new GamePresenter(this);
        ball.onReachDestination += _gamePresenter.TotalScore;
    }


    public void ValidateValues(string error)
    {
        if (error.Length > 0)
        {
            _errorText.text = error;
        }
        else
        {
            InputUI.SetActive(false);
            ball.Shoot();
        }

    }
    
    public void TotalScore(int total)
    {
        totalScoreObj.SetActive(true);
        totalScoreText.text = total.ToString();
    }

    public void Shoot()
    {
        _gamePresenter.Validate(_inputField.text);
    }

}
