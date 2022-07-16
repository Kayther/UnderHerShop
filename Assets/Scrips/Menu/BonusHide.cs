using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusHide : MonoBehaviour
{
    public GameObject BonusBut;
    void Start()
    {
        if (VariableManager.bonus == false)
        {
            BonusBut.SetActive(false);
        }
        else
        {
            BonusBut.SetActive(true);
        }
    }
}
