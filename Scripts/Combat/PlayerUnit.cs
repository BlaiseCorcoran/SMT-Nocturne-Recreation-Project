using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrUnits : MonoBehaviour
{
    //PURPOSE: THIS SCRIPT WILL CONTAIN GENERAL THINGS FOR EACH PLAYER UNIT

    //keeps track of the amount of units in place
    public int CurrentUnits;

    //All necessary info for each unit
    public string UnitName;
    public string UnitLvl;
    public int maxHP;
    public int currHP;
    public int maxMP;
    public int currMP;
    public string Race;                 
    public string weakness;             
    public string resist;               
    public string block;                 
    public string[] Skills;
    public string[] Inventory;
    public int str;                      
    public int mag;                    
    public int vit;                     
    public int agi;                    
    public int luc;                    
}
