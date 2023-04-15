using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using View;

public class GamePresenter
{
    private IView gameView;
    private Game gameModel;


    private List<int> ShootValues;
    
    public GamePresenter(IView gameView)
    {
        this.gameView = gameView;
        gameModel = new Game();

        ShootValues = new List<int>();
    }

    public void Validate(string textInput)
    {
        bool haveText = textInput.Length > 0;
        bool correctString = textInput.Contains(",");

        bool correctNumbers = false;
        bool greaterNumbers = false;
        string[] values = textInput.Split(',');



        for (int i = 0; i < values.Length; i++)
        {
            int n;
            correctNumbers = int.TryParse(values[i], out n);

            if (n > 10)
                greaterNumbers = true;
            
            if (correctNumbers)
            {
                ShootValues.Add(n);
            }
            else
            {
                break;
            }
        }

        string error = "";
        
        if (!haveText)
        {
            error = "Debe ingresar algun valor";
        }else if (!correctString)
        {
            error = "Debe separar los tiros con comas (,)";
        }else if (!correctNumbers)
        {
            error = "Asegurese de solo ingresar valores validos";
        }else if (greaterNumbers)
        {
            error = "Ninguna tirada puede ser superior a 10";
        }
        
        gameView.ValidateValues(error);
    }

    public void TotalScore()
    {
        int total = gameModel.GameScore(ShootValues.ToArray());
        
        gameView.TotalScore(total);
    }
}
