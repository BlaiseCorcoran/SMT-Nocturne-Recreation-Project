using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

//battle coniditions
public enum BattleState { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class BattleSystem : MonoBehaviour
{
    //This script is based off of a script from https://youtu.be/_1pz_ohupPs?si=zfv7xSUTLQu103ay
    //PURPOSE: THIS SCRIPT WILL ACT AS OUR BATTLE SYSTEM USING THE DEFINED STATES
    //         NOTE THAT THIS SCRIPT WILL ONLY BE USED IN THE FIRST BATTLE

    //game obj's
    public GameObject player;
    public GameObject enemy;

    public Image panel;
    public Image stats;
    public Button playerAction;

    //Battle dialogue
    public Text dialogue;
    public TextMeshProUGUI hpMark;
    public Text plyerHP;
    public Text maxPlyerHP;
    public TextMeshProUGUI mpMark;
    public Text plyerMP;
    public Text maxPlyerMP;
    public Text Plyername;
    public TextMeshProUGUI slash;
    public TextMeshProUGUI slash2;

    //location of object instances
    public Transform playerLoc;
    public Transform enemyLoc;

    //Player and Enemy Object's
    PlayerStats PLAYER;
    WillOWispStats will;

    //HUD Disp.
    public BattleHUD playerHUD;

    //current state of battle
    public BattleState state;

    // Start is called before the first frame update
    void Start()
    {
        panel.enabled = false;
        playerAction.gameObject.SetActive(false);
        stats.enabled = false;
        hpMark.enabled = false;
        mpMark.enabled = false;
        maxPlyerHP.enabled = false;
        maxPlyerMP.enabled = false;
        plyerHP.enabled = false;
        plyerMP.enabled = false;
        Plyername.enabled = false;
        slash.enabled = false;
        slash2.enabled = false;

    //Start of player turn
    state = BattleState.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        panel.enabled = false;
        playerAction.gameObject.SetActive(false);
        stats.enabled = false;
        hpMark.enabled = false;
        mpMark.enabled = false;
        maxPlyerHP.enabled = false;
        maxPlyerMP.enabled = false;
        plyerHP.enabled = false;
        plyerMP.enabled = false;
        Plyername.enabled = false;
        slash.enabled = false;
        slash2.enabled = false;

        GameObject playerBEGIN = Instantiate(player, playerLoc);
        PLAYER = playerBEGIN.GetComponent<PlayerStats>();

        GameObject enemy1BEGIN = Instantiate(enemy, enemyLoc);
        will = enemy1BEGIN.GetComponent<WillOWispStats>();

        dialogue.text = "An enemy has appeared";

        //Disp. Player Stats and turns
        playerHUD.setHUD(PLAYER);

        yield return new WaitForSeconds(2f);
        
        state = BattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator EnemyTurn()
    {
        panel.enabled = false;
        playerAction.gameObject.SetActive(false);
        stats.enabled = false;
        hpMark.enabled = false;
        mpMark.enabled = false;
        maxPlyerHP.enabled = false;
        maxPlyerMP.enabled = false;
        plyerHP.enabled = false;
        plyerMP.enabled = false;
        Plyername.enabled = false;
        slash.enabled = false;
        slash2.enabled = false;

        dialogue.text = "Enemy's Turn";

        yield return new WaitForSeconds(2f);

        int enemyDmg = 3; //keep the dmg at 3 for now
        dialogue.text = "Enemy Attacks and does " + enemyDmg + " damage";

        yield return new WaitForSeconds(2f);

        //bool dead = PLAYER.TakeDmg(enemyDmg, currHP);
        PLAYER.HP = PLAYER.HP - enemyDmg;
        playerHUD.setHUD(PLAYER);

        if(PLAYER.HP <= 0)
        {
            state = BattleState.LOST;
            //send the player to the game over screen
        }
        else
        {
            state = BattleState.PLAYERTURN;
            PlayerTurn();
        }
       
    }

    //send the player to the elevator if they won
    //send the player to the title screen if they lost
    void EndBattle()
    {
        if (state == BattleState.WON)
        {
            StartCoroutine(winMsg());
        }
        else if (state == BattleState.LOST)
        {
            dialogue.text = "You were defeated.";
            //take the player to the game over screen
        }
    }

    IEnumerator winMsg()
    {
        panel.enabled = false;
        playerAction.gameObject.SetActive(false);
        stats.enabled = false;
        hpMark.enabled = false;
        mpMark.enabled = false;
        maxPlyerHP.enabled = false;
        maxPlyerMP.enabled = false;
        plyerHP.enabled = false;
        plyerMP.enabled = false;
        Plyername.enabled = false;
        slash.enabled = false;
        slash2.enabled = false;

        dialogue.text = "You won the battle!";
        yield return new WaitForSeconds(2f);
        dialogue.text = "You Learned Analyze Skill and Lunge Skill";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //send the player to the credits page
    }

    IEnumerator loseMsg()
    {
        panel.enabled = false;
        playerAction.gameObject.SetActive(false);
        stats.enabled = false;
        hpMark.enabled = false;
        mpMark.enabled = false;
        maxPlyerHP.enabled = false;
        maxPlyerMP.enabled = false;
        plyerHP.enabled = false;
        plyerMP.enabled = false;
        Plyername.enabled = false;
        slash.enabled = false;
        slash2.enabled = false;
        
        dialogue.text = "You lost the battle! GAME OVER!";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    void PlayerTurn()
    {
        panel.enabled = true;
        playerAction.gameObject.SetActive(true);
        stats.enabled = true;
        hpMark.enabled = true;
        mpMark.enabled = true;
        maxPlyerHP.enabled = true;
        maxPlyerMP.enabled = true;
        plyerHP.enabled = true;
        plyerMP.enabled = true;
        Plyername.enabled = true;
        slash.enabled = true;
        slash2.enabled = true;

        dialogue.text = "what will you do?";
        
    }

    //activates when player uses the attack command
    public void OnAttack()
    {
        if(state != BattleState.PLAYERTURN)
        {
            return;
        }

        StartCoroutine(PlayerAttack());
    }

    //When the player presses the attack button
    IEnumerator PlayerAttack()
    {
        int dmg = PLAYER.skillDmgAtk(); //damage is determined by this attribute
        will.HP = will.HP - dmg;

        dialogue.text = "You Attack and Do " + dmg + " damage";

        yield return new WaitForSeconds(2f);

        //Only use this when debugging 
        /*
        dialogue.text = "Enemy now has " + will.HP + " health";

        yield return new WaitForSeconds(2f);
        */


        if (will.HP <= 0)
        {
            state = BattleState.WON;
            EndBattle();
        }
        else
        {
            state = BattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }

    }

}
