using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColorChange : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private float speed;

    private TextMeshProUGUI tmp;

    public bool darker;
    private bool resetPos;

    private void Start()
    {
        startPosY = transform.position.y;
        startPosX = transform.position.x;
        tmp = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos;
        mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        if (darker == true && resetPos == true)
        {
            if (speed <= 0.5)
            {
                speed += 0.001f;
            }
            transform.position = new Vector2(Random.Range(startPosX - speed, startPosX + speed), Random.Range(startPosY - speed, startPosY + speed));
        }

    }
    private void OnMouseEnter()
    {
        SFX.Touch();
        tmp.color = new Color(tmp.color.r, tmp.color.g, 0, tmp.color.a);
        resetPos = true;
    }

    private void OnMouseExit()
    {
        tmp.color = new Color(tmp.color.r, tmp.color.g, 1, tmp.color.a);
        resetPos = false;
        speed = 0;
        transform.position = new Vector2(startPosX, startPosY);
    }
}
