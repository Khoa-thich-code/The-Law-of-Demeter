 Class 4: using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerUI : MonoBehaviour
{
    [SerializeField] GunUI gunUI;
    public void RedrawUI()
    {
        Player player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        print(player.health);
        gunUI.RedrawUI(player.gun);
    }
}
  
