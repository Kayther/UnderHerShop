using UnityEngine;
using UnityEngine.UI;

public class Stats : MonoBehaviour
{
    public Transform camara;
    public GameObject pointsBar;
    public Slider bossSlider;
    public Slider fameSlider;
    public Slider timeSlider;
    public Slider supSlider;

    public bool main;

    private void Start()
    {
        if (main == false)
        {
            bossSlider.value = VariableManager.slideBoss;
            fameSlider.value = VariableManager.slideFame;
            timeSlider.value = VariableManager.slideTime;
            supSlider.value = VariableManager.slideSup;

            VariableManager.payBoss = 10 + 75 * (2 * bossSlider.value);
            VariableManager.payFame = 10 + 100 * (2 * fameSlider.value);
            VariableManager.payTime = 10 + 75 * (2 * timeSlider.value);
            VariableManager.paySup = 1250;

        }
    }

    public void Right()
    {
            SFX.Click();
            camara.position = new Vector3 (camara.position.x + 122, camara.position.y,camara.position.z);
    }

    public void Left()
    {
            SFX.Click();
            camara.position = new Vector3(camara.position.x - 122, camara.position.y, camara.position.z);        
    }

    public void Reseting()
    {
        ResetWarning.menuOpen = true;
    }

    public void UpgradeBoss()
    {
        if (bossSlider.value <= 9 
            && VariableManager.total >= 10 + 75 * (2 * bossSlider.value))
        {
            SFX2.LvUp();
            VariableManager.total -= 10 + (75 * (2 * bossSlider.value));
            bossSlider.value += 1;
            VariableManager.slideBoss += 1;
            VariableManager.payBoss = 10 + 75 * (2 * bossSlider.value);
        }
    }
    public void UpgradeTip()
    {
        if (fameSlider.value <= 9 
            && VariableManager.total >= 10 + 100 * (2 * fameSlider.value))
        {
            SFX2.LvUp();
            VariableManager.total -= 10 + (100 * (2 * fameSlider.value));
            fameSlider.value += 1;
            VariableManager.slideFame += 1;
            VariableManager.payFame = 10 + 100 * (2 * fameSlider.value);
        }
    }
    public void UpgradeTime()
    {
        if (timeSlider.value <= 9 
            && VariableManager.total >= 10 + 75 * (2 * timeSlider.value))
        {
            SFX2.LvUp();
            VariableManager.total -= 10 + (75 * (2 * timeSlider.value));
            timeSlider.value += 1;
            VariableManager.slideTime += 1;
            VariableManager.payTime = 10 + 75 * (2 * timeSlider.value);
        }
    }
    public void UpgradeSup()
    {
        if (supSlider.value < 1
            && VariableManager.total >= 1250)
        {
            SFX2.LvUp();
            supSlider.value += 1;
            VariableManager.slideSup += 1;
            VariableManager.total -= 1250;
            VariableManager.paySup = 1250;
        }
    }
}
