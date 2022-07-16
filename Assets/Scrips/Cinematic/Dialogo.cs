using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    private AudioSource au;

    public float typeTime;
    CineStart cine;
    [SerializeField] private AudioClip sVoice;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField] private SpriteRenderer globo;
    [SerializeField, TextArea] private string[] dialogos;

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
