using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public enum BossBattleState { START, PLAYERTURN, ALLYTURN, ENEMYTURN, WON, LOST }

public class BattleSystemBoss : MonoBehaviour
{
    //This script is based off of a script from https://youtu.be/_1pz_ohupPs?si=zfv7xSUTLQu103ay
    //PURPOSE: THIS SCRIPT WILL ACT AS OUR BATTLE SYSTEM USING THE DEFINED STATES ABOVE
    //         NOTE THAT THIS SCRIPT WILL ONLY BE USED IN THE BOSS BATTLE

    //game obj's
    public GameObject player;
    public GameObject Forneus;
    public GameObject ally;

    //hud stuff
    public Image panel2;
    public Image statsBar;
    public Button attackBtn;
    public Button analyzeBtn;
    public Button LungeBtn;
    public Button attackBtn2;
    public Button zioBtn;
    public Button Meds;
    public Text dialogue;
    //player
    public TextMeshProUGUI hpMark;
    public Text plyerHP;
    public Text maxPlyerHP;
    public TextMeshProUGUI mpMark;
    public Text plyerMP;
    public Text maxPlyerMP;
    public Text Plyername;
    public TextMeshProUGUI slash;
    public TextMeshProUGUI slash2;
    //ally
    public TextMeshProUGUI hpMark2;
    public Text allyHP;
    public Text allyMP;
    public TextMeshProUGUI mpMark2;
    public Text alliedmaxHP;
    public Text alliedmaxMP;
    public Text alliedName;
    public TextMeshProUGUI slash3;
    public TextMeshProUGUI slash4;

    //location of object instances
    public Transform playerLoc;
    public Transform allyLoc;
    public Transform enemyLoc;

    //Player and Enemy Object's
    PlayerStats PLAYER;
    PixieStats pix;
    ForneusStats Forn;

    //HUD Disp.
    public BattleHUD playerHUD;
    public BattleHUDDemons allyHUD;

    //current state of battle
    public BossBattleState state;

    // Start is called before the first frame update
    void Start()
    {
        //images
        panel2.enabled = false;
        statsBar.enabled = false;
        //buttons
        attackBtn.gameObject.SetActive(false);
        analyzeBtn.gameObject.SetActive(false);
        LungeBtn.gameObject.SetActive(false);
        attackBtn2.gameObject.SetActive(false);
        zioBtn.gameObject.SetActive(false);
        Meds.gameObject.SetActive(false);
        //player text
        hpMark.enabled = false;
        hpMark2.enabled = false;
        mpMark.enabled = false;
        mpMark2.enabled = false;
        plyerHP.enabled = false;
        maxPlyerHP.enabled = false;
        allyHP.enabled = false;
        allyMP.enabled = false;
        alliedmaxMP.enabled = false;
        alliedmaxHP.enabled = false;
        plyerMP.enabled = false;
        maxPlyerMP.enabled = false;
        Plyername.enabled = false;
        slash.enabled = false;
        slash2.enabled = false;
        slash3.enabled = false;
        slash4.enabled = false;
        alliedName.enabled = false;


        //Start of player turn
        state = BossBattleState.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        //images
        panel2.enabled = false;
        statsBar.enabled = false;
        //buttons
        attackBtn.gameObject.SetActive(false);
        analyzeBtn.gameObject.SetActive(false);
        LungeBtn.gameObject.SetActive(false);
        attackBtn2.gameObject.SetActive(false);
        zioBtn.gameObject.SetActive(false);
        Meds.gameObject.SetActive(false);
        //player text
        hpMark.enabled = false;
        hpMark2.enabled = false;
        mpMark.enabled = false;
        mpMark2.enabled = false;
        plyerHP.enabled = false;
        maxPlyerHP.enabled = false;
        allyHP.enabled = false;
        allyMP.enabled = false;
        alliedmaxMP.enabled = false;
        alliedmaxHP.enabled = false;
        plyerMP.enabled = false;
        maxPlyerMP.enabled = false;
        Plyername.enabled = false;
        slash.enabled = false;
        slash2.enabled = false;
        slash3.enabled = false;
        slash4.enabled = false;
        alliedName.enabled = false;

        GameObject playerBEGIN = Instantiate(player, playerLoc);
        PLAYER = playerBEGIN.GetComponent<PlayerStats>();

        GameObject allyBEGIN = Instantiate(ally, allyLoc);
        pix = allyBEGIN.GetComponent<PixieStats>();

        GameObject bossBEGIN = Instantiate(Forneus, enemyLoc);
        Forn = bossBEGIN.GetComponent<ForneusStats>();

        dialogue.text = "You Have Encountered Forneus";

        //Disp. Player Stats and turns
        playerHUD.setHUD(PLAYER);
        allyHUD.setHUDpix(pix);

        yield return new WaitForSeconds(2f);

        state = BossBattleState.PLAYERTURN;
        PlayerTurn();
    }

    IEnumerator EnemyTurn()
    {
        //images
        panel2.enabled = false;
        statsBar.enabled = false;
        //buttons
        attackBtn.gameObject.SetActive(false);
        analyzeBtn.gameObject.SetActive(false);
        LungeBtn.gameObject.SetActive(false);
        attackBtn2.gameObject.SetActive(false);
        zioBtn.gameObject.SetActive(false);
        Meds.gameObject.SetActive(false);
        //player text
        hpMark.enabled = false;
        hpMark2.enabled = false;
        mpMark.enabled = false;
        mpMark2.enabled = false;
        plyerHP.enabled = false;
        maxPlyerHP.enabled = false;
        allyHP.enabled = false;
        allyMP.enabled = false;
        alliedmaxMP.enabled = false;
        alliedmaxHP.enabled = false;
        plyerMP.enabled = false;
        maxPlyerMP.enabled = false;
        Plyername.enabled = false;
        slash.enabled = false;
        slash2.enabled = false;
        slash3.enabled = false;
        slash4.enabled = false;
        alliedName.enabled = false;

        dialogue.text = "Boss's Turn";

        yield return new WaitForSeconds(2f);

        int enemyDmg = 10; 
        dialogue.text = "Enemy Attacks and does " + enemyDmg + " damage";

        yield return new WaitForSeconds(2f);

        PLAYER.HP = PLAYER.HP - enemyDmg;
        playerHUD.setHUD(PLAYER);

        if (PLAYER.HP <= 0)
        {
            state = BossBattleState.LOST;
            EndBattle();
        }
        else
        {
            state = BossBattleState.PLAYERTURN;
            PlayerTurn();
        }

    }

    //send the player to the elevator if they won
    //send the player to the title screen if they lost
    void EndBattle()
    {
        if (state == BossBattleState.WON)
        {
            StartCoroutine(winMsg());
        }
        else if (state == BossBattleState.LOST)
        {
            StartCoroutine(loseMsg());
            //take the player to the game over screen
        }
    }

    IEnumerator winMsg()
    {
        //images
        panel2.enabled = false;
        statsBar.enabled = false;
        //buttons
        attackBtn.gameObject.SetActive(false);
        analyzeBtn.gameObject.SetActive(false);
        LungeBtn.gameObject.SetActive(false);
        attackBtn2.gameObject.SetActive(false);
        zioBtn.gameObject.SetActive(false);
        Meds.gameObject.SetActive(false);
        //player text
        hpMark.enabled = false;
        hpMark2.enabled = false;
        mpMark.enabled = false;
        mpMark2.enabled = false;
        plyerHP.enabled = false;
        maxPlyerHP.enabled = false;
        allyHP.enabled = false;
        allyMP.enabled = false;
        alliedmaxMP.enabled = false;
        alliedmaxHP.enabled = false;
        plyerMP.enabled = false;
        maxPlyerMP.enabled = false;
        Plyername.enabled = false;
        slash.enabled = false;
        slash2.enabled = false;
        slash3.enabled = false;
        slash4.enabled = false;
        alliedName.enabled = false;

        dialogue.text = "You won the battle!";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 18); //send the player to the credits page
    }

    IEnumerator loseMsg()
    {
        //images
        panel2.enabled = false;
        statsBar.enabled = false;
        //buttons
        attackBtn.gameObject.SetActive(false);
        analyzeBtn.gameObject.SetActive(false);
        LungeBtn.gameObject.SetActive(false);
        attackBtn2.gameObject.SetActive(false);
        zioBtn.gameObject.SetActive(false);
        Meds.gameObject.SetActive(false);
        //player text
        hpMark.enabled = false;
        hpMark2.enabled = false;
        mpMark.enabled = false;
        mpMark2.enabled = false;
        plyerHP.enabled = false;
        maxPlyerHP.enabled = false;
        allyHP.enabled = false;
        allyMP.enabled = false;
        alliedmaxMP.enabled = false;
        alliedmaxHP.enabled = false;
        plyerMP.enabled = false;
        maxPlyerMP.enabled = false;
        Plyername.enabled = false;
        slash.enabled = false;
        slash2.enabled = false;
        slash3.enabled = false;
        slash4.enabled = false;
        alliedName.enabled = false;

        dialogue.text = "You lost the battle! GAME OVER!";
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 18); 
    }

    void PlayerTurn()
    {
        //images
        panel2.enabled = true;
        statsBar.enabled = true;
        //buttons
        attackBtn.gameObject.SetActive(true);
        analyzeBtn.gameObject.SetActive(true);
        LungeBtn.gameObject.SetActive(true);
        Meds.gameObject.SetActive(true);
        //text
        hpMark.enabled = true;
        hpMark2.enabled = true;
        mpMark.enabled = true;
        mpMark2.enabled = true;
        plyerHP.enabled = true;
        maxPlyerHP.enabled = true;
        allyHP.enabled = true;
        allyMP.enabled = true;
        alliedmaxMP.enabled = true;
        alliedmaxHP.enabled = true;
        plyerMP.enabled = true;
        maxPlyerMP.enabled = true;
        Plyername.enabled = true;
        slash.enabled = true;
        slash2.enabled = true;
        slash3.enabled = true;
        slash4.enabled = true;
        alliedName.enabled = true;

        dialogue.text = "what will you do?";

    }

    void AllyTurn()
    {
        attackBtn2.gameObject.SetActive(true);
        zioBtn.gameObject.SetActive(true);
        attackBtn.gameObject.SetActive(false);
        analyzeBtn.gameObject.SetActive(false);
        LungeBtn.gameObject.SetActive(false);
        Meds.gameObject.SetActive(false);
        dialogue.text = "What will you command kodama to do?";
    }

    //activates when player uses the attack command
    public void OnAttack()
    {
        if (state != BossBattleState.PLAYERTURN)
        {
            return;
        }

        StartCoroutine(PlayerAttack());
    }

    //activates when the plater uses the Lunge skill
    public void OnLunge()
    {
        if (PLAYER.HP <= 12)
        {
            dialogue.text = "You Do Not Have enough HP to use this";
            return;
        }

        if (state != BossBattleState.PLAYERTURN)
        {
            return;
        }

        StartCoroutine(PlayerLunge());
    }


    //When the player presses the attack button
    IEnumerator PlayerAttack()
    {
        int dmg = PLAYER.skillDmgAtk(); //damage is determined by this attribute
        Forn.HP = Forn.HP - dmg;

        dialogue.text = "You Attack and Do " + dmg + " damage";

        yield return new WaitForSeconds(2f);

        if (Forn.HP <= 0)
        {
            state = BossBattleState.WON;
            EndBattle();
        }
        else
        {
            state = BossBattleState.ALLYTURN;
            AllyTurn();
        }

    }

    //When the player presses the attack button
    IEnumerator PlayerLunge()
    {
        //remove 12HP as the cost for using this attack
        PLAYER.HP = PLAYER.HP - 12;
        playerHUD.setHUD(PLAYER);
        int dmg = PLAYER.skillDmgLunge(); //damage is determined by this attribute
        Forn.HP = Forn.HP - dmg;

        dialogue.text = "You Attack and Do " + dmg + " damage";

        yield return new WaitForSeconds(2f);

        if (Forn.HP <= 0)
        {
            state = BossBattleState.WON;
            EndBattle();
        }
        else
        {
            state = BossBattleState.ALLYTURN;
            AllyTurn();
        }

    }

    //When the player presses the Analyze button
    IEnumerator PlayerAnalyze()
    {
        //remove 2MP as the cost for using this attack
        PLAYER.MP = PLAYER.MP - 2;
        playerHUD.setHUD(PLAYER);

        dialogue.text = "Forneus Has " + Forn.HP + " HP";

        yield return new WaitForSeconds(2f);

        if (Forn.HP <= 0)
        {
            state = BossBattleState.WON;
            EndBattle();
        }
        else
        {
            state = BossBattleState.ALLYTURN;
            AllyTurn();
        }

    }

    public void OnAnalyze()
    {
        if (pix.MP <= 2)
        {
            dialogue.text = "You Do Not Have enough MP to use this";
            return;
        }

        if (state != BossBattleState.PLAYERTURN)
        {
            return;
        }

        StartCoroutine(PlayerAnalyze());
    }


    public void OnPixAttack()
    {
        if(state != BossBattleState.ALLYTURN)
        {
            return;
        }
       
        StartCoroutine(PixieAttack());
    }

    IEnumerator PixieAttack()
    {
        int dmg = pix.skillDmgAtk(); //damage is determined by this attribute
        Forn.HP = Forn.HP - dmg;

        dialogue.text = "Pixie Attacks and Does " + dmg + " damage";

        yield return new WaitForSeconds(2f);

        if (Forn.HP <= 0)
        {
            state = BossBattleState.WON;
            EndBattle();
        }
        else
        {
            state = BossBattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }

    public void OnPixZio()
    {
        if (pix.MP <= 3)
        {
            dialogue.text = "Pixie does not have enough MP to use this skill";
            return;
        }

        if (state != BossBattleState.ALLYTURN)
        {
            return;
        }

        StartCoroutine(PixieZio());
    }

    IEnumerator PixieZio()
    {
        pix.MP = pix.MP - 3;
        allyHUD.setHUDpix(pix);
        int dmg = pix.skillDmgZio(); //damage is determined by this attribute
        dmg = dmg * 2;
        Forn.HP = Forn.HP - dmg;

        dialogue.text = "Kodama Uses Zio and Does " + dmg + " damage";

        yield return new WaitForSeconds(2f);

        if (Forn.HP <= 0)
        {
            state = BossBattleState.WON;
            EndBattle();
        }
        else
        {
            state = BossBattleState.ENEMYTURN;
            StartCoroutine(EnemyTurn());
        }
    }

    public void OnMeds()
    {
        if (state != BossBattleState.PLAYERTURN)
        {
            return;
        }

        if (PLAYER.HP == PLAYER.maxHP)
        {
            dialogue.text = "You are already at max HP!";
            return;
        }

        if (PLAYER.MP <= 5)
        {
            dialogue.text = "You do not have enough MP to use this skill!";
            return;
        }

        StartCoroutine(meds());
    }


    IEnumerator meds()
    {
        
        PLAYER.HP = PLAYER.HP + 20;
        PLAYER.MP = PLAYER.MP - 5;
        playerHUD.setHUD(PLAYER);

        if (PLAYER.HP > PLAYER.maxHP)
        {
            PLAYER.HP = PLAYER.maxHP;
        }

        dialogue.text = "You used Medicine and Healed 20HP";
        yield return new WaitForSeconds(2f);

        if (Forn.HP <= 0)
        {
            state = BossBattleState.WON;
            EndBattle();
        }
        else
        {
            state = BossBattleState.ALLYTURN;
            AllyTurn();
        }
    }
}
