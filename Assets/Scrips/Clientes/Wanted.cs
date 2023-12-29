using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanted : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite Swant1;
    public Sprite Nwant1;

    public Sprite Swant2;
    public Sprite Nwant2;

    public Sprite Swant3;
    public Sprite Nwant3;

    public Sprite Swant4;
    public Sprite Nwant4;

    public Sprite Swant5;
    public Sprite Nwant5;

    public Sprite Shate1;
    public Sprite Nhate1;

    public Sprite Shate2;
    public Sprite Nhate2;

    public Sprite Shate3;
    public Sprite Nhate3;

    public Sprite Shate4;
    public Sprite Nhate4;

    public Sprite Shate5;
    public Sprite Nhate5;

    public GameObject wantItem;
    Cliente wantedI;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        wantedI = wantItem.GetComponent<Cliente>();
    }

    private void Update()
    {
        ChangeSprite(wantedI.wantItem);
    }

    public void ChangeSprite(int income)
    {
        if(VariableManager.NSFW == true)
        {
            if (wantedI.haterMode == true)
            {
                switch (income)
                {
                    case 4:
                        sr.sprite = Nhate5;
                        break;

                    case 3:
                        sr.sprite = Nhate4;
                        break;

                    case 2:
                        sr.sprite = Nhate3;
                        break;

                    case 1:
                        sr.sprite = Nhate2;
                        break;

                    case 0:
                        sr.sprite = Nhate1;
                        break;

                    default:
                        print("Rare error kinda sussy");
                        break;
                }
            }
            else
            {
                switch (income)
                {
                    case 4:
                        sr.sprite = Nwant5;
                        break;

                    case 3:
                        sr.sprite = Nwant4;
                        break;

                    case 2:
                        sr.sprite = Nwant3;
                        break;

                    case 1:
                        sr.sprite = Nwant2;
                        break;

                    case 0:
                        sr.sprite = Nwant1;
                        break;

                    default:
                        print("Rare error kinda sussy");
                        break;
                }
            }
        }
        else
        {
            if (wantedI.haterMode == true)
            {
                switch (income)
                {
                    case 4:
                        sr.sprite = Shate5;
                        break;

                    case 3:
                        sr.sprite = Shate4;
                        break;

                    case 2:
                        sr.sprite = Shate3;
                        break;

                    case 1:
                        sr.sprite = Shate2;
                        break;

                    case 0:
                        sr.sprite = Shate1;
                        break;

                    default:
                        print("Rare error kinda sussy");
                        break;
                }
            }
            else
            {
                switch (income)
                {
                    case 4:
                        sr.sprite = Swant5;
                        break;

                    case 3:
                        sr.sprite = Swant4;
                        break;

                    case 2:
                        sr.sprite = Swant3;
                        break;

                    case 1:
                        sr.sprite = Swant2;
                        break;

                    case 0:
                        sr.sprite = Swant1;
                        break;

                    default:
                        print("Rare error kinda sussy");
                        break;
                }
            }
        }

    }
}
