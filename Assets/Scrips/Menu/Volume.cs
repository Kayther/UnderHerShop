using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public class Volume : MonoBehaviour
{
    public AudioSource sfx;
    public AudioSource mus;

    public Slider sfxSlider;
    public Slider musSlider;

    public AudioMixer mixMus;
    public AudioMixer mixSFX;

    private float controlSFX;
    private float controlMUS;

    // Start is called before the first frame update
    void Start()
    {
        sfxSlider.value = VariableManager.sfxVol;
        musSlider.value = VariableManager.musVol;

        controlSFX = VariableManager.sfxVol;
        controlMUS = VariableManager.musVol;
    }

    public void SFXChange() 
    {
        sfx.Stop();
        sfx.Play(); 
    }
    public void MusChange()
    {
        //mus.Stop();
        //mus.Play();
    }

    public void SetLevelSFX()
    {
        mixSFX.SetFloat("SFXVol", Mathf.Log10(sfxSlider.value) * 20);
    }

    public void SetLevelMus()
    {
        mixMus.SetFloat("MusicVol", Mathf.Log10 (musSlider.value) * 20);
    }
}
