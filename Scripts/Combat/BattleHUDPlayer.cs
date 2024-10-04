using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUD : MonoBehaviour
{
    public Text NAMEOFUNIT;
    public Text HP;
    public Text MP;
    public Text maxHP;
    public Text maxMP;
    public Slider HPslide;
    public Slider MPslide;

    public void setHUD(PlayerStats thePlayer)
    {
        //Disp. Name
        NAMEOFUNIT.text = thePlayer.PlayerDN;

        //Disp. HP
        HP.text = thePlayer.HP.ToString();

        //Disp. MP
        MP.text = thePlayer.MP.ToString();

        //Disp. max HP
        maxHP.text = thePlayer.maxHP.ToString();

        //Disp. max MP
        maxMP.text = thePlayer.maxMP.ToString();

    }


    public void setHP(int HP)
    {
        HPslide.value = HP;
    }

    public void setMP(int MP)
    {
        HPslide.value = MP;
    }
}
