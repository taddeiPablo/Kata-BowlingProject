using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootButton : MonoBehaviour
{
    public Action OnShoot;
    
    public void Shoot()
    {
        OnShoot?.Invoke();
    }
}
