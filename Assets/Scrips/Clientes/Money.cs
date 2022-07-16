using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    static public void Payment(float income)
    {
        VariableManager.total += income;
    }
}
