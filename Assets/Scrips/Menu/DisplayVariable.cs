using UnityEngine;
using TMPro;

public class DisplayVariable : MonoBehaviour
{
	private TextMeshProUGUI goldCount;

    public bool toGold;
    public bool toBoss;
    public bool toTip;
    public bool toTime;
    public bool toSup;
    public bool toDay;
    public bool toFame;


    private void Start()
    {
		goldCount = GetComponent<TextMeshProUGUI>();

    }

    private void Update()
    {
        if (toDay == true)
        {
            goldCount.text = "Dia " + VariableManager.dayCount.ToString();
        }
        else
        {
            if (toGold == true)
            {
                float goldNum = Mathf.Round(VariableManager.total);
                goldCount.text = "O" + goldNum.ToString();
            }

            if (toBoss == true)
            {
                goldCount.text = "O" + VariableManager.payBoss.ToString();
            }

            if (toTip == true)
            {
                goldCount.text = "O" + VariableManager.payFame.ToString();
            }

            if (toTime == true)
            {
                goldCount.text = "O" + VariableManager.payTime.ToString();
            }

            if (toSup == true)
            {
                goldCount.text = "O" + VariableManager.paySup.ToString();
            }

            if (toFame == true)
            {
                float fameNum = Mathf.Round(VariableManager.fame);
                goldCount.text = "Fama " + fameNum.ToString();
            }
        }
    }

}