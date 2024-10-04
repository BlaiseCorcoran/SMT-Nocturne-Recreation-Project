using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForneusStats : MonoBehaviour
{
    //PURPOSE: Provides the stats for Forneus

    public string Dname;                 //Demon's name
    public string Race;                  //Demon's Race
    public string weakness;              //Demon's Weakness
    public string resist;                //Element that the Demon is Resistant to
    public string block;                 //Element that Demon blocks
    public string[] Skills;              //Demon's Skills
    public int HP;                       //Demon's HP
    public int MP;                       //Demon's MP

    //temp
    public int EXPdrops;
    public int MaccaDrop;


    //start
    void Start()
    {
        BossStats();

        if(HP == 0)
        {
            Drops();
        }
    }

    //Boss stats
    public void BossStats()
    {
        Dname = "Forneus";
        Race = "Fallen";
        weakness = "Electric";
        resist = "None";
        block = "None";
        HP = 500;
        MP = 200;

        string[] Skills = { "Bufu", "Mabufu", "Icy Death" };

    }

    //Boss Drops
    public void Drops()
    {
        //keep it like this for now
        //later on, make sure it reads:
        //player.currExp += 150;
        //player.Macca += 2000;
        EXPdrops = 150;
        MaccaDrop = 2000;
    }

}
