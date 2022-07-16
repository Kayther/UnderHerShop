using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cliente : MonoBehaviour
{

    public int wantItem;
    private int reciveItem;
    private int face;
    private int manyServed;
    public float tipRate;
    private bool served;
    private bool bossMode;
    [HideInInspector]public bool haterMode;

    private SpriteRenderer sr;

    public Sprite chik1;
    public Sprite happyChik1;
    public Sprite chik2;
    public Sprite happyChik2;
    public Sprite chik3;
    public Sprite happyChik3;
    public Sprite chik4;
    public Sprite happyChik4;
    public Sprite chik5;
    public Sprite happyChik5;
    public Sprite boss;
    public Sprite happyBoss;

    GameObject spawner;
    public GameObject wanting;
    Life life;
    

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        wantItem = Random.Range(0, 5);

        spawner = GameObject.Find("Spawn");

        life = GetComponent<Life>();

        face = Random.Range(0, 5);

        sr.color = new Vector4(sr.color.r, sr.color.g, sr.color.b, 0);
        int rand = (Random.Range(0, (70-VariableManager.dayCount/2 - VariableManager.slideBoss*5)));
        switch (rand)
        {
            case 0:
                sr.sprite = boss;
                bossMode = true;
                life.maxHp = life.maxHp * (3f + VariableManager.slideBoss/7.5f);
                life.hp = life.maxHp;
                transform.localScale = new Vector3(1.45f, 1.45f, 1f);
                transform.position = new Vector3(transform.position.x, 16.15f, transform.position.z);
                life.isBoss = true;
                wanting.transform.localScale = new Vector3(0.35f, 0.35f, 1f);
                wanting.transform.position = new Vector3(wanting.transform.position.x, this.transform.position.y + 15.5f, wanting.transform.position.z);
                break;
            default:
                switch (face)
                {
                    case 4:
                        sr.sprite = chik5;
                        break;
                    case 3:
                        sr.sprite = chik4;
                        break;
                    case 2:
                        sr.sprite = chik3;
                        break;
                    case 1:
                        sr.sprite = chik2;
                        break;
                    case 0:
                        sr.sprite = chik1;
                        break;
                    default:
                        sr.sprite = chik1;
                        print("Rare error kinda sussy");
                        break;
                }
                switch (Random.Range(0, (25 - VariableManager.dayCount/4)))
                {
                    case 0:
                        haterMode = true;
                        break;
                    default:

                        break;

                }
                break;
        }
        StartCoroutine(InFade());
    }

    private void Update()
    {
        if (life.dead == true)
        {
            StartCoroutine(OutFade());
        }
    }

    public void ReciveItem(int income)
    {
        reciveItem = income;

        if (served == false)
        {
            if (haterMode == false)
            {
                if (reciveItem == wantItem)
                {
                    if (life.hp > 75)
                    {
                        VariableManager.fame += 3 * (1 + VariableManager.slideFame / 5);
                        tipRate = tipRate + 2;
                        SFX.CashX3();
                    }
                    else if (life.hp > 40)
                    {
                        VariableManager.fame += 2 * (1 + VariableManager.slideFame / 5);
                        tipRate = tipRate + 1.5f;
                        SFX.CashX2();
                    }
                    else
                    {
                        VariableManager.fame += 1 * (1 + VariableManager.slideFame / 5);
                        tipRate = 1;
                        SFX.CashX1();
                    }


                    Money.Payment(5 + VariableManager.fame / 10);
                    if (bossMode == true)
                    {
                        manyServed++;
                        wantItem = Random.Range(0, 5);
                        if (manyServed >= 3)
                        {
                            VariableManager.fame += 15;
                            served = true;
                            Money.Payment(20 + VariableManager.fame / 10);
                            StartCoroutine(OutFade());
                        }
                    }
                    else
                    {
                        served = true;
                        StartCoroutine(OutFade());
                    }
                }
            }
            else
            {
                if (!(reciveItem == wantItem))
                {
                    if (life.hp > 75)
                    {
                        VariableManager.fame += 3 * (1 * VariableManager.slideFame / 2);
                        tipRate = tipRate + 2;
                        SFX.CashX3();
                    }
                    else if (life.hp > 40)
                    {
                        VariableManager.fame += 2 * (1 * VariableManager.slideFame / 3);
                        tipRate = tipRate + 1.5f;
                        SFX.CashX2();
                    }
                    else
                    {
                        VariableManager.fame += 1 * (1 * VariableManager.slideFame / 4);
                        tipRate = 1;
                        SFX.CashX1();
                    }


                    Money.Payment(5 + VariableManager.fame / 10);
                    if (bossMode == true)
                    {
                        manyServed++;
                        wantItem = Random.Range(0, 5);
                        if (manyServed >= 3)
                        {
                            VariableManager.fame += 15;
                            served = true;
                            Money.Payment(50 + VariableManager.fame / 7.5f);
                            StartCoroutine(OutFade());
                        }
                    }
                    else
                    {
                        served = true;
                        StartCoroutine(OutFade());
                    }
                }
            }
        }
    }

    public int GetWant()
    {
        return wantItem;
    }

    public IEnumerator InFade()
    {
        for (float alpha = 0; alpha <= 1.5f; alpha += 0.1f)
        {
            sr.color = new Vector4(sr.color.r, sr.color.g, sr.color.b, alpha);
            yield return new WaitForSeconds(.01f);
        }
    }

    public IEnumerator OutFade()
    {
        if (life.dead == true)
        {
        }
        else
        {
            if (bossMode == true)
            {
                sr.sprite = happyBoss;
            }
            else
            {
                switch (face)
                {
                    case 4:
                        sr.sprite = happyChik5;
                        break;
                    case 3:
                        sr.sprite = happyChik4;
                        break;
                    case 2:
                        sr.sprite = happyChik3;
                        break;
                    case 1:
                        sr.sprite = happyChik2;
                        break;
                    case 0:
                        sr.sprite = happyChik1;
                        break;
                    default:
                        print("Rare error kinda sussy");
                        break;
                }
            }
        }
        for (float alpha = 1; alpha >= 0; alpha -= 0.1f)
        {
            sr.color = new Vector4(sr.color.r, sr.color.g, sr.color.b, alpha);
            yield return new WaitForSeconds(.01f);
        }
        if (life.dead == true 
            && VariableManager.endDay == false)
        {
            if (boss == true)
            {
                VariableManager.fame -= 10 * (2 + VariableManager.slideFame / 10);
            }
            else
            {
                VariableManager.fame -= 3 * (1 + VariableManager.slideFame / 10);
            }
        }
        Spawn.clientes--;
        Destroy(gameObject);
    }
}
