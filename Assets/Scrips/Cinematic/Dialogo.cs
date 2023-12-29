using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Localization.Settings;


public class Dialogo : MonoBehaviour
{
    private AudioSource au;

    public float typeTime;
    CineStart cine;
    [SerializeField] private AudioClip sVoice;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private SpriteRenderer globo;
    private string[] dialogosES = { "*hola chica, ¿como estas?", 
        "*sabes por que estoy aqui, ¿no?", 
        "*tienes que pagar tu deuda.", 
        "*...", 
        "*si, se que es duro, pero solo soy la mensajera",
        "*estoy segura que si te esfuerzas puedes hacerlo",
        "*solo tienes que conseguir 125.000 en 20 dias.",
        "*...",
        "*empieza a trabajar muchacha.",
        "*gracias, tu tambien eres linda.",
        "*nos vemos."};
    private string[] dialogosEN = { "*hello gal, how are 'ya?",
        "*you know why i'm here, right?",
        "*you have to pay your debt.",
        "*...",
        "*yeah, i know is hard, but I'm just the messenger",
        "*i'm pretty sure you can do it",
        "*you only have to get 125.000 in 20 days.",
        "*...",
        "*start workin'.",
        "*thanks, you're also a cutie pie.",
        "*see 'ya."};
    private string[] dialogosTR = { "Merhaba kızım, nasılsın?",
         "neden burada olduğumu biliyorsun, değil mi?",
         "borcunu ödemelisin.",
         "...",
         "evet, zor olduğunu biliyorum ama ben sadece elçiyim",
         "Bunu yapabileceğinden oldukça eminim",
         "sadece 20 günde 125.000 kazanmanız gerekiyor.",
         "...",
         "çalışmaya başla.",
         "teşekkürler, sen de çok tatlısın.",
         "*görüşürüz."};
    private string[] dialogos;

    private int lineIndex;
    private bool starto;
    private bool ended;
    private bool untouch;

    // Start is called before the first frame update
    void Start()
    {
        cine = gameObject.GetComponent<CineStart>();
        au = GetComponent<AudioSource>();
        au.clip = sVoice;

        switch (LocalizationSettings.SelectedLocale.ToString())
        {
            case "Spanish (es)":
                dialogos = dialogosES;
                break;
            case "English (en)":
                dialogos = dialogosEN;
                break;
            case "Turkish (tr)":
                dialogos = dialogosTR;
                break;
            default:
                break;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && starto == true && untouch == false)
        {
                if (dialogueText.text == dialogos[lineIndex])
                {
                    NextDialogue();
                }
                else if (ended == false)
                {
                    StopAllCoroutines();
                    dialogueText.text = dialogos[lineIndex];
                }
        }

    }

    public void NextDialogue()
    {
        lineIndex++;
        if (lineIndex < dialogos.Length)
        {
            StartCoroutine(ShowLine());
        }
        else
        {
            dialogueText.text = string.Empty;
            ended = true;
            untouch = true;
            StartCoroutine(cine.EndingDialogue());
        }
    }

    public void dialogoStart()  
    {
        starto = true;
        StartCoroutine(ShowLine());
    }

    private IEnumerator ShowLine()
    {
        dialogueText.text = string.Empty;
        int charIndex = 0;
        cine.ChangeSprite(lineIndex);

        foreach(char ch in dialogos[lineIndex])
        {
            dialogueText.text += ch;
            if (charIndex % 3 == 0)
            {
                au.Play();
            }
            charIndex++;
            yield return new WaitForSeconds(typeTime);
        }
    }
}
