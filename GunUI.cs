using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunUI : MonoBehaviour
{
    public void RedrawUI(Gun gun)
    {
        print(gun.GetRoundLeft());
    }
}
