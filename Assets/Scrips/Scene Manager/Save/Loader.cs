using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour
{
    public bool loadingMode;

    public static bool savePetition;

    public static float boss;
    public static float total;

    public static int slideBoss;
    public static float slideFame;
    public static float slideTime;
    public static float slideSup;

    public static float payBoss;
    public static float payFame;
    public static float payTime;
    public static float paySup;

    public static float sfxVol = 1;
    public static float musVol = 1;

    public static int dayCount = 1;
    public static float fame;

    public static bool tutorial = true;
    public static bool tutorial2;
    public static bool firstPlay;

    public static bool bonus;

    // Start is called before the first frame update
    void Start()
    {
        if (loadingMode == false)
        {
            SaveTouch();
        }
        else
        {
            VariableManager.Loading();
        }
    }

    private void Update()
    {
        if (savePetition == true)
        {
            savePetition = false;
            SaveTouch();
        }
    }

    public void SaveTouch()
    {
        boss = VariableManager.boss;
        total = VariableManager.total;

        slideBoss = VariableManager.slideBoss;
        slideFame = VariableManager.slideFame;
        slideTime = VariableManager.slideTime;
        slideSup = VariableManager.slideSup;

        payBoss = VariableManager.payBoss;
        payFame = VariableManager.payFame;
        payTime = VariableManager.payTime;
        paySup = VariableManager.paySup;

        musVol = VariableManager.sfxVol;
        musVol = VariableManager.musVol;

        dayCount = VariableManager.dayCount;
        fame = VariableManager.fame;

        tutorial = VariableManager.tutorial;
        tutorial2 = VariableManager.tutorial2;
        firstPlay = VariableManager.firstPlay;

        bonus = VariableManager.bonus;
        Saver.SaveData(this);
    }
}
