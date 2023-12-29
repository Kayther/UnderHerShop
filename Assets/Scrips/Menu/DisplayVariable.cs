using UnityEngine;
using TMPro;
using UnityEngine.Localization;



public class DisplayVariable : MonoBehaviour
{
	private TextMeshProUGUI goldCount;

    public LocalizedStringTable localizedString;

    public bool toGold;
    public bool toBoss;
    public bool toTip;
    public bool toTime;
    public bool toSup;
    public bool toDay;
    public bool toFame;

    private string dayLang;
    private string fameLang;

    private void Start()
    {
		goldCount = GetComponent<TextMeshProUGUI>();
        if (toDay == true)
        {
            var table = localizedString.GetTable();
            string finalDay = table.GetEntry("Day").ToString();
            dayLang = finalDay.Substring(18);
            Debug.Log(table);
            Debug.Log(finalDay);
            Debug.Log(table.GetEntry("Day"));
        }
        if (toFame == true)
        {
            var table = localizedString.GetTable();
            string finalFama = table.GetEntry("Fama").ToString();
            fameLang = finalFama.Substring(14);
        }
    }

    private void Update()
    {
        if (toDay == true)
        {
            Debug.Log(dayLang);
            goldCount.text = dayLang + " " + VariableManager.dayCount.ToString();
        }
        else
        {
            if (toGold == true)
            {
                float goldNum = Mathf.Round(VariableManager.total);
                goldCount.text = "G" + goldNum.ToString();
            }

            if (toBoss == true)
            {
                goldCount.text = "G" + VariableManager.payBoss.ToString();
            }

            if (toTip == true)
            {
                goldCount.text = "G" + VariableManager.payFame.ToString();
            }

            if (toTime == true)
            {
                goldCount.text = "G" + VariableManager.payTime.ToString();
            }

            if (toSup == true)
            {
                goldCount.text = "G" + VariableManager.paySup.ToString();
            }

            if (toFame == true)
            {
                float fameNum = Mathf.Round(VariableManager.fame);
                goldCount.text = fameLang + " " + fameNum.ToString();
            }
        }
    }

}