using UnityEngine;
using UnityEngine.SceneManagement;

public class Finale : MonoBehaviour
{
    private int creditsGo = 0;

    public GameObject win;
    public GameObject lose;
    public GameObject space;
    public GameObject credits;
    public GameObject creditsDos;

    Loader loadin;

    // Start is called before the first frame update
    void Start()
    {
        WinOrLose wol = gameObject.GetComponent<WinOrLose>();
        credits.SetActive(false);
        creditsDos.SetActive(false);
        loadin = gameObject.GetComponent<Loader>();
        if (VariableManager.total >= 125000f)
        {
            lose.SetActive(false);
            wol.xmusHopesNDreams.Play();
        }
        else
        {
            win.SetActive(false);
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
                lose.SetActive(false);
                win.SetActive(false);
                space.SetActive(false);
                credits.SetActive(true);
                creditsGo = 1;
            }
            else if (creditsGo == 1)
            {
                credits.SetActive(false);
                creditsDos.SetActive(true);
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
