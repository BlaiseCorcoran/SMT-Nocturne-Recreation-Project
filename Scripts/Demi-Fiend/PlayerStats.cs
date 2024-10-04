using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //PURPOSE: This script will contain ALL necessary info for the player in the overworld and in battle
    public string PlayerFName;           //player's first name
    public string PlayerLName;           //player's last name
    public string PlayerDN;              //player's display name
    public int HP;                       //Player's HP
    public int maxHP;
    public int MP;                       //Player's MP
    public int maxMP;
    public string[] Inventory;           //Player's Items
    public string[] Skills;              //Player's skills
    public int str;                      //Player's strength
    public int mag;                      //Player's magic
    public int vit;                      //Player's vitality
    public int agi;                      //Player's agility
    public int luc;                      //Player's luck
    public int currExp;                  //Player's current experience points
    public int playerLvl;                //Player's current level
   


    //base player stats
    public void baseStats()
    {
        //name info
        PlayerFName = "Naoki";
        PlayerLName = "Kashima";
        PlayerDN = "Demi-Fiend";

        //level and exp info
        playerLvl = 1;
        currExp = 0;

        //player stats
        HP = 30;
        maxHP = 30;
        MP = 12;
        maxMP = 12;
        str = 4;
        mag = 3;
        vit = 4;
        agi = 3; 
        luc = 3;
        //skills
        Skills = new string[5];
        Skills[0] = "Attack"; //basic attack
    }

    //resets player data
    void resetGameData()
    {
        baseStats();
    }

    //if the player starts a new game, call resetGameData()

    //level ups 
    //Level cap is 7
    //DO NOT FORGET TO ADD STAT DISTRIBUTION
    //RULES FOR STAT DISTRIBUTION:
    //1.) Player picks stat to level up
    //2.) For each level gained, player gets one stat dist. point
    public bool levelUpHappens()
    {
        //level 2
        //to next 6
        if(currExp >= 6)
        {
            //"You leveled up! Please ustomize your stats." msg goes here
            //add stat boost here
            playerLvl = 2;
            str += 2;
            mag += 1;
            vit += 2;
            agi += 1;
            luc += 1;

            return true;
        }

        //level 3
        //to next 27
        //learn lunge
        if(currExp >= 33)
        {
            //"You leveled up! Please ustomize your stats." msg goes here
            //add stat boost here
            playerLvl = 3;
            str += 2;
            mag += 1;
            vit += 2;
            agi += 1;
            luc += 1;

            return true;
        }

        //level 4
        //to next 51
        //learn analyze
        if(currExp >= 84)
        {
            //"You leveled up! Please ustomize your stats." msg goes here
            //add stat boost here
            playerLvl = 4;
            str += 2;
            mag += 1;
            vit += 2;
            agi += 1;
            luc += 1;

            return true;
        }

        //level 5
        //to next 86
        if (currExp >= 170)
        {
            //"You leveled up! Please ustomize your stats." msg goes here
            //add stat boost here
            playerLvl = 5;
            str += 2;
            mag += 1;
            vit += 2;
            agi += 1;
            luc += 1;

            return true;
        }

        //level 6
        //to next 129
        if (currExp >= 299)
        {
            //"You leveled up! Please ustomize your stats." msg goes here
            //add stat boost here
            playerLvl = 6;
            str += 2;
            mag += 1;
            vit += 2;
            agi += 1;
            luc += 1;

            return true;
        }

        //level 7
        //to next 181
        if (currExp >= 480)
        {
            //"You leveled up! Please ustomize your stats." msg goes here
            //add stat boost here
            playerLvl = 7;
            str += 2;
            mag += 1;
            vit += 2;
            agi += 1;
            luc += 1;

            return true;
        }

        else
        {
            return false;
        }

    }

    //damage for Attack skill
    public int skillDmgAtk()
    {
        int dmg = (playerLvl + str) * 25 / 25;
        return dmg;
    }

    //damage for Lunge skill
    public int skillDmgLunge()
    {
        int dmg = maxHP * 41 * 51/5000;

        return dmg;
    }
}
