using UnityEngine;
using UnityEngine.Audio;

public class SFX2 : MonoBehaviour
{
    static public AudioSource lvUp;
    public AudioSource xlvUp;

    //songs
    //music shop
    static public AudioSource musMuffet;
    public AudioSource xmusMuffet;
    static public AudioSource musHoii;
    public AudioSource xmusHoii;
    static public AudioSource musBass;
    public AudioSource xmusBass;
    static public AudioSource musShop;
    public AudioSource xmusShop;
    static public AudioSource musTem;
    public AudioSource xmusTem;
    static public AudioSource musDate;
    public AudioSource xmusDate;
    static public AudioSource musTrap;
    public AudioSource xmusTrap;

    static public AudioMixer mixSFX;

    private float controlSFX;
    private float controlMUS;


    // Start is called before the first frame update
    void Start()
    {
        controlSFX = VariableManager.sfxVol;
        controlMUS = VariableManager.musVol;
        lvUp = xlvUp;

        musMuffet = xmusMuffet;
        musHoii = xmusHoii;
        musBass = xmusBass;
        musShop = xmusShop;
        musTem = xmusTem;
        musDate = xmusDate;
        musTrap = xmusTrap;
    }

    static public void LvUp()
    {
        lvUp.Play();
    }

    static public void MusActivator()
    {
        if (VariableManager.firstPlay == false)
        {
            musShop.Play();
            VariableManager.firstPlay = true;
        }
        else
        {
            switch (Random.Range(0, 7))
            {
                case 6:
                    musTrap.Play();
                    break;
                case 5:
                    musDate.Play();
                    break;
                case 4:
                    musTem.Play();
                    break;
                case 3:
                    musHoii.Play();
                    break;
                case 2:
                    switch (Random.Range(0, 6))
                    {
                        case 0:
                            musBass.Play();
                            break;
                        default:
                            MusActivator();
                            break;
                    }
                    break;
                case 1:
                    musShop.Play();
                    break;
                case 0:
                    musMuffet.Play();
                    break;
                default:
                    print("Rare error kinda sussy");
                    break;
            }
        }
    }

    static public void MusDesactivator()
    {
        musMuffet.Stop();
    }
}
