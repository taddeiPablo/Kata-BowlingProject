using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Action onReachDestination;
     
    public void Shoot()
    {
        transform.LeanMoveLocalY(779, 3).setEaseInBack().setOnComplete(End);
    }

    private void End()
    {
        onReachDestination?.Invoke();
    }
}
