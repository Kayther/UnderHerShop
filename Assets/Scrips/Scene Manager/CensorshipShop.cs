using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CensorshipShop : MonoBehaviour
{

    // Items
    [SerializeField]
    Sprite SbunnyIMG;
    [SerializeField]
    Sprite NbunnyIMG;
    [SerializeField]
    Sprite SNegabunnyIMG;
    [SerializeField]
    Sprite NNegabunnyIMG;
    [SerializeField]
    SpriteRenderer bunny;

    [SerializeField]
    Sprite SbandIMG;
    [SerializeField]
    Sprite NbandIMG;
    [SerializeField]
    Sprite SNegabandIMG;
    [SerializeField]
    Sprite NNegabandIMG;
    [SerializeField]
    SpriteRenderer band;

    [SerializeField]
    Sprite SiceIMG;
    [SerializeField]
    Sprite NiceIMG;
    [SerializeField]
    Sprite SNegaiceIMG;
    [SerializeField]
    Sprite NNegaiceIMG;
    [SerializeField]
    SpriteRenderer ice;

    [SerializeField]
    Sprite SgloveIMG;
    [SerializeField]
    Sprite NgloveIMG;
    [SerializeField]
    Sprite SNegagloveIMG;
    [SerializeField]
    Sprite NNegagloveIMG;
    [SerializeField]
    SpriteRenderer glove;

    [SerializeField]
    Sprite SmilkIMG;
    [SerializeField]
    Sprite NmilkIMG;
    [SerializeField]
    Sprite SNegamilkIMG;
    [SerializeField]
    Sprite NNegamilkIMG;
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
            //bg.sprite = NbgClosedIMG;

            bunny.sprite = NbunnyIMG;
            band.sprite = NbandIMG;
            ice.sprite = NiceIMG;
            glove.sprite = NgloveIMG;
            milk.sprite = NmilkIMG;
        }
        else
        {
            //bg.sprite = SbgClosedIMG;

            bunny.sprite = SbunnyIMG;
            band.sprite = SbandIMG;
            ice.sprite = SiceIMG;
            glove.sprite = SgloveIMG;
            milk.sprite = SmilkIMG;
        }

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log(VariableManager.NSFW);
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
