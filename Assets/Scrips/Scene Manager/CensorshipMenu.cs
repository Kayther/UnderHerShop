using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CensorshipMenu : MonoBehaviour
{
    //Main Menu
    [SerializeField]
    SpriteRenderer SFWIMG;
    [SerializeField]
    SpriteRenderer NSFWIMG;
    [SerializeField]
    Sprite SbonusIMG;
    [SerializeField]
    Sprite NbonusIMG;
    [SerializeField]
    SpriteRenderer bonus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (VariableManager.NSFW == true)
        {
            NSFWIMG.color = new Vector4(1, 1, 1, 1); ;
            SFWIMG.color = new Vector4(0.5649714f, 0.7169812f, 0.3348167f, 1); ;
        }
        else
        {
            NSFWIMG.color = new Vector4(0.1556604f, 0.2836322f, 1, 1); ;
            SFWIMG.color = new Vector4(1, 1, 1, 1); ;
        }
    }

    public void ChangeNSFW(bool type)
    {
        if (type == true)
        {
            VariableManager.NSFW = true;
        }
        else
        {
            VariableManager.NSFW = false;
        }
    }
}
