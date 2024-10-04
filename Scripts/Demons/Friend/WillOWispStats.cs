using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WillOWispStats : MonoBehaviour
{
    //PURPOSE: Provides the stats for Will O' Wisp

    public string Dname;                 //Demon's name
    public string Race;                  //Demon's Race
    public string weakness;              //Demon's Weakness
    public string resist;                //Element that the Demon is Resistant to
    public string block;                 //Element that Demon blocks
    public string[] Skills;              //Demon's Skills
    public int HP;                       //Demon's HP
    public int maxHP;
    public int MP;                       //Demon's MP
    public int maxMP;
    public int str;                      //Demon's strength
    public int mag;                      //Demon's magic
    public int vit;                      //Demon's vitality
    public int agi;                      //Demon's agility
    public int luc;                      //Demon's luck
    public int currExp;                  //Demon's current experience points
    public int DemonLvl;                 //Demon's current level


    //demon stats
    void BeginningStats()
    {
        Dname = "Will O' Wisp";
        Race = "Foul";
        weakness = "Any Magic";
        resist = "Physical";
        block = "Dark";
        HP = 10;
        maxHP = 10;
        MP = 18;
        maxMP = 18;
        DemonLvl = 1;
        str = 4;
        mag = 5;
        vit = 4;
        agi = 5;
        luc = 3;

        Skills= new string[7]; 
        Skills[0] = "Attack"; 
        Skills[1] = "Deathtouch";  
        Skills[2] = "Makajaka";
        Skills[3] = "Needle Rush";
    }




    //we'll add this later on
    //void LevelUp()
}
