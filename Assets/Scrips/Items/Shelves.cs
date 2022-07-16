using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shelves : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;

    public static bool onlyOne;

    // Update is called once per frame
    private void Update()
    {
        if (VariableManager.slideSup >= 1 && onlyOne == false)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                Instantiate(item1, new Vector3(50, 5, 0), Quaternion.identity);
                onlyOne = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                Instantiate(item2, new Vector3(50, 5, 0), Quaternion.identity);
                onlyOne = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                Instantiate(item3, new Vector3(50, 5, 0), Quaternion.identity);
                onlyOne = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                Instantiate(item4, new Vector3(50, 5, 0), Quaternion.identity);
                onlyOne = true;
            }
            if (Input.GetKeyDown(KeyCode.Alpha5))
            {
                Instantiate(item5, new Vector3(50, 5, 0), Quaternion.identity);
                onlyOne = true;
            }     
        }
    }
}

