using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    private float Second = 1f;
    private Coroutine MyCoroutin;

    private float timer;

    [Header("Popularity")]
    public int popDicreaseMultiplier;
    public float popMax;
    public float popular;
    public Image popularity;
    public Sprite popFull;
    public Sprite popEmpty;
    public Sprite
        pop1,
        pop2,
        pop3,
        pop4,
        pop5,
        pop6,
        pop7,
        pop8,
        pop9,
        pop10,
        pop11,
        pop12,
        pop13,
        pop14,
        pop15,
        pop16,
        pop17,
        pop18,
        pop19,
        pop20,
        pop21,
        pop22,
        pop23,
        pop24,
        pop25,
        pop26,
        pop27,
        pop28,
        pop29,
        pop30,
        pop31,
        pop32,
        pop33,
        pop34,
        pop35,
        pop36,
        pop37,
        pop38,
        pop39,
        pop40,
        pop41,
        pop42,
        pop43,
        pop44,
        pop45,
        pop46,
        pop47,
        pop48,
        pop49,
        pop50,
        pop51,
        pop52,
        pop53,
        pop54,
        pop55,
        pop56,
        pop57,
        pop58,
        pop59,
        pop60,
        pop61,
        pop62,
        pop63,
        pop64,
        pop65;


    [Header("Score")]
    public float score;
    public int scoreMultiplier;
    public Text scoreCounter;


    [Header("Health")]
    private const int healthMax = 3;
    public int health;  //  Здоровье игрока
    public Image
        healthBar;  // Хранение разных спрайтов для полоски здоровья
    public Sprite
        healthThree,
        healthTwo,
        healthOne,
        healthZero;

    // Start is called before the first frame update
    void Start()
    {
        MyCoroutin = StartCoroutine(AddScore());

        popular = popMax / 3;
        health = healthMax;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        score = (int) score;
        scoreCounter.text = score.ToString();
        HealUpdate();
        PopularityUpdate();
    }


    IEnumerator AddScore()
    {
        while (true)
        {
            score = score + popular * scoreMultiplier;
            popular = popular - (timer / popDicreaseMultiplier + 1);
            


            yield return new WaitForSeconds(Second);
        }
    }

    private void HealUpdate()
    {   //  Проверка количества здоровья
        if (health > healthMax)  //  ограничители по количеству здоровья
            health = healthMax;
        if (health < 0)
            health = 0;

        if (health == 3)
        {
            healthBar.sprite = healthThree;
        }
        else if (health == 2)
        {
            healthBar.sprite = healthTwo;
        }
        else if (health == 1)
        {
            healthBar.sprite = healthOne;
        }
        else if (health == 0)
        {
            healthBar.sprite = healthZero;
        }
    }

    private void PopularityUpdate()
    {
        if (popular < 0)  //  границы кол-ва монет
            popular = 0;
        if (popular > popMax)
            popular = popMax;

        if (popular == popMax)  //  выбор спрайта в зависимости от количества монет относительно максимума
        {
            popularity.sprite = popFull;
        }
        else if ((popular < popMax) && (popular > popMax / 65 * 64))
        {
            popularity.sprite = pop1;
        }
        else if ((popular < popMax / 65 * 64) && (popular > popMax / 65 * 63))
        {
            popularity.sprite = pop2;
        }
        else if ((popular < popMax / 65 * 63) && (popular > popMax / 65 * 62))
        {
            popularity.sprite = pop3;
        }
        else if ((popular < popMax / 65 * 62) && (popular > popMax / 65 * 61))
        {
            popularity.sprite = pop4;
        }
        else if ((popular < popMax / 65 * 61) && (popular > popMax / 65 * 60))
        {
            popularity.sprite = pop5;
        }
        else if ((popular < popMax / 65 * 60) && (popular > popMax / 65 * 59))
        {
            popularity.sprite = pop6;
        }
        else if ((popular < popMax / 65 * 59) && (popular > popMax / 65 * 58))
        {
            popularity.sprite = pop7;
        }
        else if ((popular < popMax / 65 * 58) && (popular > popMax / 65 * 57))
        {
            popularity.sprite = pop8;
        }
        else if ((popular < popMax / 65 * 57) && (popular > popMax / 65 * 56))
        {
            popularity.sprite = pop9;
        }
        else if ((popular < popMax / 65 * 56) && (popular > popMax / 65 * 55))
        {
            popularity.sprite = pop10;
        }
        else if ((popular < popMax / 65 * 55) && (popular > popMax / 65 * 54))
        {
            popularity.sprite = pop11;
        }
        else if ((popular < popMax / 65 * 54) && (popular > popMax / 65 * 53))
        {
            popularity.sprite = pop12;
        }
        else if ((popular < popMax / 65 * 53) && (popular > popMax / 65 * 52))
        {
            popularity.sprite = pop13;
        }
        else if ((popular < popMax / 65 * 52) && (popular > popMax / 65 * 51))
        {
            popularity.sprite = pop14;
        }
        else if ((popular < popMax / 65 * 51) && (popular > popMax / 65 * 50))
        {
            popularity.sprite = pop15;
        }
        else if ((popular < popMax / 65 * 50) && (popular > popMax / 65 * 49))
        {
            popularity.sprite = pop16;
        }
        else if ((popular < popMax / 65 * 49) && (popular > popMax / 65 * 48))
        {
            popularity.sprite = pop17;
        }
        else if ((popular < popMax / 65 * 48) && (popular > popMax / 65 * 47))
        {
            popularity.sprite = pop18;
        }
        else if ((popular < popMax / 65 * 47) && (popular > popMax / 65 * 46))
        {
            popularity.sprite = pop19;
        }
        else if ((popular < popMax / 65 * 46) && (popular > popMax / 65 * 45))
        {
            popularity.sprite = pop20;
        }
        else if ((popular < popMax / 65 * 45) && (popular > popMax / 65 * 44))
        {
            popularity.sprite = pop21;
        }
        else if ((popular < popMax / 65 * 44) && (popular > popMax / 65 * 43))
        {
            popularity.sprite = pop22;
        }
        else if ((popular < popMax / 65 * 43) && (popular > popMax / 65 * 42))
        {
            popularity.sprite = pop23;
        }
        else if ((popular < popMax / 65 * 42) && (popular > popMax / 65 * 41))
        {
            popularity.sprite = pop24;
        }
        else if ((popular < popMax / 65 * 41) && (popular > popMax / 65 * 40))
        {
            popularity.sprite = pop25;
        }
        else if ((popular < popMax / 65 * 40) && (popular > popMax / 65 * 39))
        {
            popularity.sprite = pop26;
        }
        else if ((popular < popMax / 65 * 39) && (popular > popMax / 65 * 38))
        {
            popularity.sprite = pop27;
        }
        else if ((popular < popMax / 65 * 38) && (popular > popMax / 65 * 37))
        {
            popularity.sprite = pop28;
        }
        else if ((popular < popMax / 65 * 37) && (popular > popMax / 65 * 36))
        {
            popularity.sprite = pop29;
        }
        else if ((popular < popMax / 65 * 36) && (popular > popMax / 65 * 35))
        {
            popularity.sprite = pop30;
        }
        else if ((popular < popMax / 65 * 35) && (popular > popMax / 65 * 34))
        {
            popularity.sprite = pop31;
        }
        else if ((popular < popMax / 65 * 34) && (popular > popMax / 65 * 33))
        {
            popularity.sprite = pop32;
        }
        else if ((popular < popMax / 65 * 33) && (popular > popMax / 65 * 32))
        {
            popularity.sprite = pop33;
        }
        else if ((popular < popMax / 65 * 32) && (popular > popMax / 65 * 31))
        {
            popularity.sprite = pop34;
        }
        else if ((popular < popMax / 65 * 31) && (popular > popMax / 65 * 30))
        {
            popularity.sprite = pop35;
        }
        else if ((popular < popMax / 65 * 30) && (popular > popMax / 65 * 29))
        {
            popularity.sprite = pop36;
        }
        else if ((popular < popMax / 65 * 29) && (popular > popMax / 65 * 28))
        {
            popularity.sprite = pop37;
        }
        else if ((popular < popMax / 65 * 28) && (popular > popMax / 65 * 27))
        {
            popularity.sprite = pop38;
        }
        else if ((popular < popMax / 65 * 27) && (popular > popMax / 65 * 26))
        {
            popularity.sprite = pop39;
        }
        else if ((popular < popMax / 65 * 26) && (popular > popMax / 65 * 25))
        {
            popularity.sprite = pop40;
        }
        else if ((popular < popMax / 65 * 25) && (popular > popMax / 65 * 24))
        {
            popularity.sprite = pop41;
        }
        else if ((popular < popMax / 65 * 24) && (popular > popMax / 65 * 23))
        {
            popularity.sprite = pop42;
        }
        else if ((popular < popMax / 65 * 23) && (popular > popMax / 65 * 22))
        {
            popularity.sprite = pop43;
        }
        else if ((popular < popMax / 65 * 22) && (popular > popMax / 65 * 21))
        {
            popularity.sprite = pop44;
        }
        else if ((popular < popMax / 65 * 21) && (popular > popMax / 65 * 20))
        {
            popularity.sprite = pop45;
        }
        else if ((popular < popMax / 65 * 20) && (popular > popMax / 65 * 19))
        {
            popularity.sprite = pop46;
        }
        else if ((popular < popMax / 65 * 19) && (popular > popMax / 65 * 18))
        {
            popularity.sprite = pop47;
        }
        else if ((popular < popMax / 65 * 18) && (popular > popMax / 65 * 17))
        {
            popularity.sprite = pop48;
        }
        else if ((popular < popMax / 65 * 17) && (popular > popMax / 65 * 16))
        {
            popularity.sprite = pop49;
        }
        else if ((popular < popMax / 65 * 16) && (popular > popMax / 65 * 15))
        {
            popularity.sprite = pop50;
        }
        else if ((popular < popMax / 65 * 15) && (popular > popMax / 65 * 14))
        {
            popularity.sprite = pop51;
        }
        else if ((popular < popMax / 65 * 14) && (popular > popMax / 65 * 13))
        {
            popularity.sprite = pop52;
        }
        else if ((popular < popMax / 65 * 13) && (popular > popMax / 65 * 12))
        {
            popularity.sprite = pop53;
        }
        else if ((popular < popMax / 65 * 12) && (popular > popMax / 65 * 11))
        {
            popularity.sprite = pop54;
        }
        else if ((popular < popMax / 65 * 11) && (popular > popMax / 65 * 10))
        {
            popularity.sprite = pop55;
        }
        else if ((popular < popMax / 65 * 10) && (popular > popMax / 65 * 9))
        {
            popularity.sprite = pop56;
        }
        else if ((popular < popMax / 65 * 9) && (popular > popMax / 65 * 8))
        {
            popularity.sprite = pop57;
        }
        else if ((popular < popMax / 65 * 8) && (popular > popMax / 65 * 7))
        {
            popularity.sprite = pop58;
        }
        else if ((popular < popMax / 65 * 7) && (popular > popMax / 65 * 6))
        {
            popularity.sprite = pop59;
        }
        else if ((popular < popMax / 65 * 6) && (popular > popMax / 65 * 5))
        {
            popularity.sprite = pop60;
        }
        else if ((popular < popMax / 65 * 5) && (popular > popMax / 65 * 4))
        {
            popularity.sprite = pop61;
        }
        else if ((popular < popMax / 65 * 4) && (popular > popMax / 65 * 3))
        {
            popularity.sprite = pop62;
        }
        else if ((popular < popMax / 65 * 3) && (popular > popMax / 65 * 2))
        {
            popularity.sprite = pop63;
        }
        else if ((popular < popMax / 65 * 2) && (popular > popMax / 65 * 1))
        {
            popularity.sprite = pop64;
        }
        else if ((popular < popMax / 65 * 1) && (popular > 0))
        {
            popularity.sprite = pop65;
        }
        else if (popular == 0)
        {
            popularity.sprite = popEmpty;
        }
    }

}
