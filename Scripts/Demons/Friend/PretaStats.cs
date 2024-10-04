using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PretaStats : MonoBehaviour
{
    //PURPOSE: Provides the stats for Preta

    public string Dname;                 //Demon's name
    public string Race;                  //Demon's Race
    public string weakness;              //Demon's Weakness
    public string resist;                //Element that the Demon is Resistant to
    public string block;                 //Element that Demon blocks
    public string[] Skills;              //Demon's Skills
    public int HP;                       //Demon's HP
    public int maxHP;
    public int maxMP;
    public int MP;                       //Demon's MP
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
        Dname = "Preta";
        Race = "Haunt";
        weakness = "Any Magic";
        resist = "None";
        block = "Death";
        HP = 30;
        maxHP = 30;
        MP = 24;
        maxMP = 24;
        DemonLvl = 4;
        str = 5;
        mag = 4;
        vit = 5;
        agi = 6;
        luc = 4;

        Skills = new string[7]; 
        Skills[0] = "Attack";
        Skills[1] = "Feral Claw";   
        Skills[2] = "Sukukaja";
        Skills[6] = "Pass";
    }


    //we'll add this later on
    //public static void LevelUp()
}
