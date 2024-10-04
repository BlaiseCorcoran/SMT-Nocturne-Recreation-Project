using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KodamaStats : MonoBehaviour
{
    //PURPOSE: Provides the stats for Kodama

    public string Dname;                 //Demon's name
    public string Race;                  //Demon's Race
    public string weakness;              //Demon's Weakness
    public string resist;                //Element that the Demon is Resistant to
    public string block;                 //Element that Demon blocks
    public string[] Skills;       //Demon's Skills
    public int HP;                //Demon's HP
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
    public void BeginningStats()
    {
        Dname = "Kodama";
        Race = "Jirae";
        weakness = "Fire";
        resist = "Force";
        block = "None";
        HP = 20;
        maxHP = 20;
        MP = 21;
        maxMP = 21;
        DemonLvl = 3;
        str = 4;
        mag = 4;
        vit = 4;
        agi = 6;
        luc = 5;

        //have the buttons display the text "enemy.Skills[index]"
        Skills = new string[7]; 
        Skills[0] = "Attack"; 
        Skills[1] = "Zan";  
        Skills[2] = "Dia";
        Skills[6] = "Pass";
    }


    //we'll add this later on
    //public static void LevelUp()
}
