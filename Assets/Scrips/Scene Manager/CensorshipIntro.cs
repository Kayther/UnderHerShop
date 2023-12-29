using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CensorshipIntro : MonoBehaviour
{
    //Intro
    [SerializeField]
    Sprite SbgClosedIMG;
    [SerializeField]
    Sprite NbgClosedIMG;
    [SerializeField]
    SpriteRenderer bg;

    // Items
    [SerializeField]
    Sprite SbunnyIMG;
    [SerializeField]
    Sprite NbunnyIMG;
    [SerializeField]
    SpriteRenderer bunny;

    [SerializeField]
    Sprite SbandIMG;
    [SerializeField]
    Sprite NbandIMG;
    [SerializeField]
    SpriteRenderer band;

    [SerializeField]
    Sprite SiceIMG;
    [SerializeField]
    Sprite NiceIMG;
    [SerializeField]
    SpriteRenderer ice;

    [SerializeField]
    Sprite SgloveIMG;
    [SerializeField]
    Sprite NgloveIMG;
    [SerializeField]
    SpriteRenderer glove;

    [SerializeField]
    Sprite SmilkIMG;
    [SerializeField]
    Sprite NmilkIMG;
    [SerializeField]
    SpriteRenderer milk;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (VariableManager.NSFW == true)
        {
            bg.sprite = NbgClosedIMG;

            bunny.sprite = NbunnyIMG;
            band.sprite = NbandIMG;
            ice.sprite = NiceIMG;
            glove.sprite = NgloveIMG;
            milk.sprite = NmilkIMG;
        }
        else
        {
            bg.sprite = SbgClosedIMG;
            bunny.sprite = SbunnyIMG;
            band.sprite = SbandIMG;
            ice.sprite = SiceIMG;
            glove.sprite = SgloveIMG;
            milk.sprite = SmilkIMG;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (VariableManager.NSFW == true)
            {
                VariableManager.NSFW = false;
            }
            else
            {
                VariableManager.NSFW = true;
            }
        }
    }
}
