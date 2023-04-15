using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game
{
    
    public int GameScore(int[] gameShoots)
    {
        int finalScore = 0;
        
        for (int i = 0; i < gameShoots.Length; i++)
        {
            if (gameShoots[i] == 10)
            {
                finalScore += gameShoots[i] + gameShoots[i+1] + gameShoots[i+2];
                Debug.Log("Strike");
                continue;
            }

            
            
            //Pendiente de solucionar
            if (i > 0 && i % 2 != 0)
            {
                if (gameShoots[i] + gameShoots[i - 1] == 10)
                {
                    finalScore += gameShoots[i] + gameShoots[i + 1];
                    Debug.Log("Spare");
                    continue;
                }

            }

            finalScore += gameShoots[i];
        }
        
        
        return finalScore;
    }
}
