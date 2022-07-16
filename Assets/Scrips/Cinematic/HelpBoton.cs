using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelpBoton : MonoBehaviour
{
    private TextMeshProUGUI help;

    private float time;

    // Start is called before the first frame update
    void Start()
    {
        help = GetComponent<TextMeshProUGUI>();
        help.text = " ";
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 12f)
        {
            help.text = "Presiona Z para avanzar";
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            time = 0;
            help.text = " ";
        }
    }
}
