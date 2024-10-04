using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHUDDemons : MonoBehaviour
{
    //PURPOSE: SET UP THE HUD FOR DEMON ALLIES AND ENEMIES

    //text
    public Text NAMEOFDEMON;
    public Text HP;
    public Text maxHP;
    public Text MP;
    public Text maxMP;
    public Text RACE;


    //sliders
    public Slider HPslider;
    public Slider MPslider;

    //sets up the HUD for will o wisp ally
    public void setHUDWOW(WillOWispStats W)
    {
        NAMEOFDEMON.text = W.Dname;
        HP.text = W.HP.ToString();
        HPslider.maxValue = W.maxHP;
        HPslider.value = W.HP;

        MP.text = W.MP.ToString();
        MPslider.maxValue = W.maxMP;
        MPslider.value = W.MP;
    }

    //sets up the HUD for will o wisp enemy
    public void setHUDWOWE(WillOWispStats W)
    {
        NAMEOFDEMON.text = W.Dname;
        RACE.text = W.Race;
    }


    //sets up the HUD for kodama ally
    public void setHUDKod(KodamaStats K)
    {
        NAMEOFDEMON.text = K.Dname;
        HP.text = K.HP.ToString();
        HPslider.maxValue = K.maxHP;
        HPslider.value = K.HP;

        MP.text = K.MP.ToString();
        MPslider.maxValue = K.maxMP;
        MPslider.value = K.MP;
    }

    //sets up the HUD for kodama enemy
    public void setHUDkodE(KodamaStats K)
    {
        NAMEOFDEMON.text = K.Dname;
        RACE.text = K.Race;
    }


    //sets up the HUD for pixie ally
    public void setHUDpix(PixieStats P)
    {
        NAMEOFDEMON.text = P.Dname;
        
        HP.text = P.HP.ToString();
        maxHP.text = P.maxHP.ToString();

        MP.text = P.MP.ToString();
        maxMP.text = P.maxMP.ToString();
    }

    //sets up the HUD for pixie enemy
    public void setHUDpixE(PixieStats P)
    {
        NAMEOFDEMON.text = P.Dname;
        RACE.text = P.Race;
    }


    //sets up the HUD for preta ally
    public void setHUDpret(PretaStats Pr)
    {
        NAMEOFDEMON.text = Pr.Dname;
        HP.text = Pr.HP.ToString();
        HPslider.maxValue = Pr.maxHP;
        HPslider.value = Pr.HP;

        MP.text = Pr.MP.ToString();
        MPslider.maxValue = Pr.maxMP;
        MPslider.value = Pr.MP;
    }

    //sets up the HUD for preta enemy
    public void setHUDpretE(PretaStats Pr)
    {
        NAMEOFDEMON.text = Pr.Dname;
        RACE.text = Pr.Race;
    }


    //updates HP
    public void setHP(int HP)
    {
        HPslider.value = HP;
    }

    //updates MP
    public void setMP(int MP)
    {
        MPslider.value = MP;
    }
}
