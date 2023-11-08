using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Gun : MonoBehaviour
{
    public Ammo ammo;
    public int GetRoundLeft()
    {
        return ammo.roundsLeft;
    }
}                                                                                                                                                                                                  
