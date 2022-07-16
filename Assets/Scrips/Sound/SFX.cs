using UnityEngine;
using UnityEngine.Audio;

public class SFX : MonoBehaviour
{
    static public AudioSource open;
    public AudioSource xopen;
    static public AudioSource grab;
    public AudioSource xgrab;
    static public AudioSource cash1;
    public AudioSource xcash1;
    static public AudioSource cash2;
    public AudioSource xcash2;

    static public AudioSource click;
    public AudioSource xclick;
    static public AudioSource touch;
    public AudioSource xtouch;

    //music home
    static public AudioSource musUwa;
    public AudioSource xmusUwa;
    //menu
    static public AudioSource musXmasTheme;
    public AudioSource xmusXmasTheme;
    static public AudioSource resteo;
    public AudioSource xresteo;

    static public AudioMixer mixSFX;

    private float controlSFX;
    private float controlMUS;


    // Start is called before the first frame update
    void Start()
    {
        controlSFX = VariableManager.sfxVol;
        controlMUS = VariableManager.musVol;
        open = xopen;
        grab = xgrab;
        cash1 = xcash1;
        cash2 = xcash2;
        click = xclick;
        touch = xtouch;

        musUwa = xmusUwa;
        musXmasTheme = xmusXmasTheme;
        resteo = xresteo;
    }

    static public void Open()
    {
        open.Stop();
        open.Play();
    }
    static public void Grab()
    {
        grab.Stop();
        grab.Play();
    }
    static public void Reseteo()
    {
        resteo.Stop();
        resteo.Play();
    }
    static public void CashX3()
    {
        cash1.Stop();
        cash2.Stop();
        cash1.Play();
        cash2.Play();
    }
    static public void CashX2()
    {
        cash1.Stop();
        cash1.Play();
    }
    static public void CashX1()
    {
        cash2.Stop();
        cash2.Play();
    }

    static public void Click()
    {
        click.Play();
    }
    static public void Touch()
    {
        touch.Play();
    }

    //music

}
