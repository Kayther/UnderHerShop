using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetWarning : MonoBehaviour
{
    public static bool menuOpen;
    public GameObject reseti;
    public GameObject menu;

    // Start is called before the first frame update
    void Start()
    {
        reseti.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (menuOpen == true)
        {
            menu.SetActive(false);
            reseti.SetActive(true);
            if (Input.GetKey(KeyCode.Space))
            {
                VariableManager.Reset();
                reseti.SetActive(false);
                menu.SetActive(true);
                SFX.Reseteo();
                Volume soni = gameObject.GetComponent<Volume>();
                soni.musSlider.value = 0.001f;
                soni.SetLevelMus();
                menuOpen = false;
            }
            if (Input.GetKey(KeyCode.C))
            {
                reseti.SetActive(false);
                menu.SetActive(true);
                menuOpen = false;
            }
        }
    }
}
