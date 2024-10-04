using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixieStats : MonoBehaviour
{
    //PURPOSE: Provides the stats for Pixie

    public string Dname;                 //Demon's name
    public string Race;                  //Demon's Race
    public string weakness;              //Demon's Weakness
    public string resist;                //Element that the Demon is Resistant to
    public string block;                 //Element that Demon blocks
    public string[] Skills;              //Demon's Skills
    public int HP;                       //Demon's HP
    public int maxHP;
    public int MP;
    public int maxMP;
    public int str;                      //Demon's strength
    public int mag;                      //Demon's magic
    public int vit;                      //Demon's vitality
    public int agi;                      //Demon's agility
    public int luc;                      //Demon's luck
    public int currExp;                  //Demon's current experience points
    public int DemonLvl;                 //Demon's current level


    //demon stats
    public void BeginningStats()
    {
        Dname = "Pixie";
        Race = "Fairy";
        weakness = "None";
        resist = "Electric";
        block = "None";
        HP = 36;
        maxHP = 36;
        MP = 24;
        maxMP = 24;
        DemonLvl = 2;
        str = 3;
        mag = 6;
        vit = 4;
        agi = 2;
        luc = 7;

        Skills = new string[7]; 
        Skills[0] = "Attack"; 
        Skills[1] = "Zio";  
        Skills[2] = "Dia";  
        Skills[6] = "Pass";
    }

    //damage for Attack skill
    public int skillDmgAtk()
    {
        int dmg = (DemonLvl + str) * 25 / 15;
        return dmg;
    }

    public int skillDmgZio()
    {
        int dmg = (DemonLvl + mag) * 35 / 10;
        return dmg;
    }
}
