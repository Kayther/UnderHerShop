using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Finale : MonoBehaviour
{
    private int creditsGo = 0;

    public TextMeshProUGUI win;
    public TextMeshProUGUI lose;
    public TextMeshProUGUI space;
    public TextMeshProUGUI credits;
    public TextMeshProUGUI creditsDos;

    Loader loadin;

    // Start is called before the first frame update 
    void Start()
    {
        WinOrLose wol = gameObject.GetComponent<WinOrLose>();
        credits.color = new Color(1, 1, 1, 0);
        creditsDos.color = new Color(1, 1, 1, 0);
        loadin = gameObject.GetComponent<Loader>();
        if (VariableManager.total >= 125000f)
        {
            lose.color = new Color(1, 1, 1, 0);
            wol.xmusHopesNDreams.Play();
        }
        else
        {
            win.color = new Color(1, 1, 1, 0);
            wol.xmusDetermination.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (creditsGo == 0)
            {
                lose.color = new Color(1, 1, 1, 0);
                win.color = new Color(1, 1, 1, 0);
                space.color = new Color(1, 1, 1, 0);
                credits.color = new Color(1, 1, 1, 1);
                creditsGo = 1;
            }
            else if (creditsGo == 1)
            {
                credits.color = new Color(1, 1, 1, 0);
                creditsDos.color = new Color(1, 1, 1, 1);
                creditsGo = 2;
            }
            else if(creditsGo == 2)
            {
                VariableManager.bonus = true;
                loadin.SaveTouch();
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
