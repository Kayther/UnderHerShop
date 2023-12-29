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
    private Animator an;

    GameObject spawner;
    public GameObject wanting;
    Life life;

    

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        an = GetComponent<Animator>();

        wantItem = Random.Range(0, 5);

        spawner = GameObject.Find("Spawn");

        life = GetComponent<Life>();

        face = Random.Range(0, 5);

        sr.color = new Vector4(sr.color.r, sr.color.g, sr.color.b, 0);
        int rand = (Random.Range(0, (70-VariableManager.dayCount/2 - VariableManager.slideBoss*5)));
        switch (rand)
        {
            case 0:
                if (VariableManager.NSFW == true)
                {
                    an.Play("Cliente_boss");
                }
                else
                {
                    an.Play("SafeCliente_boss");
                }
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
                if(VariableManager.NSFW == true)
                {
                    switch (face)
                    {
                        case 4:
                            an.Play("SafeCliente_5");
                            break;
                        case 3:
                            an.Play("SafeCliente_4");
                            break;
                        case 2:
                            an.Play("SafeCliente_3");
                            break;
                        case 1:
                            an.Play("SafeCliente_2");
                            break;
                        case 0:
                            an.Play("SafeCliente_1");
                            break;
                        default:
                            an.Play("SafeCliente_1");
                            print("Rare error kinda sussy");
                            break;
                    }
                }
                else
                {
                    switch (face)
                    {
                        case 4:
                            an.Play("Cliente_5");
                            break;
                        case 3:
                            an.Play("Cliente_4");
                            transform.position = new Vector2(transform.position.x, -0.6f);
                            break;
                        case 2:
                            an.Play("Cliente_3");
                            break;
                        case 1:
                            an.Play("Cliente_2");
                            transform.position = new Vector2(transform.position.x, 4.75f);
                            break;
                        case 0:
                            an.Play("Cliente_1");
                            break;
                        default:
                            an.Play("Cliente_1");
                            print("Rare error kinda sussy");
                            break;
                    }
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
        else
        {
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
                if (VariableManager.NSFW == false)
                {
                    an.Play("Cliente_boss_Happy");
                }
                else
                {
                    an.Play("SafeCliente_boss_Happy");
                }
            }
            else
            {
                if (VariableManager.NSFW == false)
                {
                    switch (face)
                    {
                        case 4:
                            an.Play("Cliente_5_Happy");
                            break;
                        case 3:
                            an.Play("Cliente_4_Happy");
                            break;
                        case 2:
                            an.Play("Cliente_3_Happy");
                            break;
                        case 1:
                            an.Play("Cliente_2_Happy");
                            break;
                        case 0:
                            an.Play("Cliente_1_Happy");
                            break;
                        default:
                            an.Play("Cliente_1_Happy");
                            print("Rare error kinda sussy");
                            break;
                    }
                }
                else
                {
                    switch (face)
                    {
                        case 4:
                            an.Play("SafeCliente_5_Happy");
                            break;
                        case 3:
                            an.Play("SafeCliente_4_Happy");
                            break;
                        case 2:
                            an.Play("SafeCliente_3_Happy");
                            break;
                        case 1:
                            an.Play("SafeCliente_2_Happy");
                            break;
                        case 0:
                            an.Play("SafeCliente_1_Happy");
                            break;
                        default:
                            an.Play("SafeCliente_1_Happy");
                            print("Rare error kinda sussy");
                            break;
                    }
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
            if (bossMode == true)
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
