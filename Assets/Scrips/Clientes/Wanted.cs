using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wanted : MonoBehaviour
{
    private SpriteRenderer sr;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite hate1;
    public Sprite hate2;
    public Sprite hate3;
    public Sprite hate4;
    public Sprite hate5;

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
        if (wantedI.haterMode == true)
        {
            switch (income)
            {
                case 4:
                    sr.sprite = hate5;
                    break;

                case 3:
                    sr.sprite = hate4;
                    break;

                case 2:
                    sr.sprite = hate3;
                    break;

                case 1:
                    sr.sprite = hate2;
                    break;

                case 0:
                    sr.sprite = hate1;
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
                    sr.sprite = sprite5;
                    break;

                case 3:
                    sr.sprite = sprite4;
                    break;

                case 2:
                    sr.sprite = sprite3;
                    break;

                case 1:
                    sr.sprite = sprite2;
                    break;

                case 0:
                    sr.sprite = sprite1;
                    break;

                default:
                    print("Rare error kinda sussy");
                    break;
            }
        }
    }
}
