using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabNDrag : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool grabed = false;

    private void Update()
    {
        if (grabed == true)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x, mousePos.y, 0);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            grabed = true;
        }
    }

    private void OnMouseUp()
    {
        grabed = false;
    }
}
