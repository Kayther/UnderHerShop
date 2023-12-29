using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class TimeToGo : MonoBehaviour
{
    float dmgSave;
    float time;
    float cd;

    public float endTime;

    private bool active;

    [SerializeField]private TextMeshProUGUI startText;

    public Slider timeSlider;

    public GameObject fondo;
    public SpriteRenderer sr;

    [SerializeField]
    Sprite SbgClosedIMG;
    [SerializeField]
    Sprite NbgClosedIMG;
    [SerializeField]
    Sprite SbgOpenIMG;
    [SerializeField]
    Sprite NbgOpenIMG;

    private void Start()
    {
        endTime = endTime + VariableManager.slideTime * 2;
        timeSlider.value = 1;
        sr = fondo.GetComponent<SpriteRenderer>();
        StartCoroutine(Starto());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            VariableManager.total += 250;
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            VariableManager.dayCount += 1;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            VariableManager.fame += 5;
        }
        if (active == true)
        {
            time += Time.deltaTime;
            cd += Time.deltaTime;

            if (cd >= 0.1)
            {
                timeSlider.value = (timeSlider.value - ((100 / (endTime - 1)) / 1000));
                cd = 0;
            }

            if (time >= endTime)
            {
                StartCoroutine(End());
            }
        }
    }

    public IEnumerator Starto()
    {
        if(VariableManager.NSFW == true)
        {
            sr.sprite = NbgClosedIMG;
        }
        else
        {
            sr.sprite = SbgClosedIMG;
        }

        VariableManager.endDay = false;
        dmgSave = Spawn.dmg;
        Spawn.clientes = 999;
        yield return new WaitForSeconds(0.001f);
        Spawn.dmg = 999;

        startText.color = new Color(1, 1, 0, startText.color.a); //amarillo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 1, startText.color.a);//blanco
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 0, 0, startText.color.a);//rojo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 0, startText.color.a); //amarillo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 1, startText.color.a);//blanco
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 0, 0, startText.color.a);//rojo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 0, startText.color.a); //amarillo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 1, startText.color.a);//blanco
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 0, 0, startText.color.a);//rojo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 0, startText.color.a); //amarillo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 1, startText.color.a);//blanco
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 0, 0, startText.color.a);//rojo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 0, startText.color.a); //amarillo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 1, startText.color.a);//blanco
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 0, 0, startText.color.a);//rojo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 0, startText.color.a); //amarillo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 1, startText.color.a);//blanco
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 0, 0, startText.color.a);//rojo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 0, startText.color.a); //amarillo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 1, startText.color.a);//blanco
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 0, 0, startText.color.a);//rojo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 0, startText.color.a); //amarillo
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 1, 1, startText.color.a);//blanco
        yield return new WaitForSeconds(0.1f);
        startText.color = new Color(1, 0, 0, startText.color.a);//rojo
        yield return new WaitForSeconds(0.1f);


        startText.text = "";
        yield return new WaitForSeconds(1f);
        if (VariableManager.NSFW == true)
        {
            sr.sprite = NbgOpenIMG;
        }
        else
        {
            sr.sprite = SbgOpenIMG;
        }

        SFX.Open();
        yield return new WaitForSeconds(0.001f);

        yield return new WaitForSeconds(1f);
        SFX2.MusActivator();
        Spawn.dmg = dmgSave;
        Spawn.clientes = 0;
        active = true;
    }

    public IEnumerator End()
    {
        Spawn.pos[0] = false;
        Spawn.pos[1] = false;
        Spawn.pos[2] = false;
        Spawn.pos[3] = false;
        Spawn.pos[4] = false;
        Spawn.pos[5] = false;

        VariableManager.endDay = true;
        int saveDay = VariableManager.dayCount;
        dmgSave = Spawn.dmg;
        Spawn.clientes = 999;
        yield return new WaitForSeconds(0.001f);
        Spawn.dmg = 999;
        SFX.Open();
        yield return new WaitForSeconds(2f);
        if (VariableManager.NSFW == true)
        {
            sr.sprite = NbgClosedIMG;
        }
        else
        {
            sr.sprite = SbgClosedIMG;
        }
        yield return new WaitForSeconds(0.001f);
        yield return new WaitForSeconds(1f);
        SFX2.MusDesactivator();
        Spawn.dmg = dmgSave;
        VariableManager.dayCount = saveDay + 1;
        VariableManager.endDay = true;
        SceneManager.LoadScene("Calendar");
    }
}
