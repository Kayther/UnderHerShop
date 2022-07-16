using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public float hp;
    public float maxHp;
    public bool dead;
    private float shelve;
    [HideInInspector] public bool isBoss;

    public GameObject hpBar;
    public Slider slider;
    public Transform life;

    private void Start()
    {
        if(VariableManager.slideSup >= 1)
        {
            shelve = 60;
        }
        maxHp += VariableManager.slideTime *24 + shelve;
        hp = maxHp;
        slider.value = GetHp();
        if (isBoss == true)
        {
            life.transform.position = new Vector3(this.transform.position.x + 1.2f, this.transform.position.y + -4.5f, life.transform.position.z);
        }
    }

    private void Update()
    {
        slider.value = GetHp();
        if (hp <= 0)
        {
            dead = true;
        }
    }

    private void FixedUpdate()
    {
        hp = hp - Spawn.dmg;
    }

    float GetHp()
    {
        return hp / maxHp;
    }
}
