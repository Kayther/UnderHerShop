
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    public GameObject menu;
    public bool secondMenu;

    // Start is called before the first frame update
    void Start()
    {
        if (secondMenu == false)
        {
            if (VariableManager.tutorial == true)
            {
                Destroy(gameObject);
            }
            else
            {
                menu.SetActive(false);
            }
        }
        else
        {
            if (VariableManager.tutorial2 == true)
            {
                Destroy(gameObject);
            }
            else
            {
                menu.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (secondMenu == false)
            {
                VariableManager.tutorial = true;
                menu.SetActive(true);
                Destroy(gameObject);
            }
            else
            {
                VariableManager.tutorial2 = true;
                menu.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
}
