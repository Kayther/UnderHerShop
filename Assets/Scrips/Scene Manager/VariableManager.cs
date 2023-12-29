using UnityEngine;

public class VariableManager
{
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
    public static bool endDay;
    public static float fame;

    public static bool tutorial = true;
    public static bool tutorial2;
    public static bool firstPlay;

    public static bool bonus;

    public static bool NSFW = true;

    public static void Reset()
    {
        boss = 0;
        total = 0;

        slideBoss = 0;
        slideFame = 0;
        slideTime = 0;
        slideSup = 0;

        payBoss = 0;
        payFame = 0;
        payTime = 0;
        paySup = 0;

        dayCount = 1;
        fame = 0;

        tutorial = true;
        tutorial2 = false;
        firstPlay = false;

        Loader.savePetition = true;
        //Loading();
    }

    public static void Loading()
    {
        Data datos = Saver.LoadData();
        if (Saver.canLoad == true)
        {
            boss = datos.boss;
            total = datos.total;

            slideBoss = datos.slideBoss;
            slideFame = datos.slideFame;
            slideTime = datos.slideTime;
            slideSup = datos.slideSup;

            payBoss = datos.payBoss;
            payFame = datos.payFame;
            payTime = datos.payTime;
            paySup = datos.paySup;

            musVol = 1;
            musVol = 1;

            dayCount = datos.dayCount;
            fame = datos.fame;

            tutorial = datos.tutorial;
            tutorial2 = datos.tutorial2;
            firstPlay = datos.firstPlay;

            bonus = datos.bonus;
        }
    }
}
