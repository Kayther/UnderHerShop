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
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 12f)
        {
            help.color = new Color(0, 0, 0, 1);
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            time = 0;
            help.color = new Color(0, 0, 0, 0);
        }
    }
}
