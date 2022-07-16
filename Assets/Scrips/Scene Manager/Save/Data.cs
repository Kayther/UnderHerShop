[System.Serializable]
public class Data
{
    public float boss;
    public float total;

    public int slideBoss;
    public float slideFame;
    public float slideTime;
    public float slideSup;

    public float payBoss;
    public float payFame;
    public float payTime;
    public float paySup;

    public float sfxVol = 1;
    public float musVol = 1;

    public int dayCount = 1;
    public float fame;

    public bool tutorial = true;
    public bool tutorial2;
    public bool firstPlay;

    public bool bonus;

    public Data(Loader datos)
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
    }
}
