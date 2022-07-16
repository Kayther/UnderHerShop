using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item1 : MonoBehaviour
{
    private float startPosX;
    private float startPosY;

    public int itemType;

    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;


    // Update is called once per frame
    void Update()
     {
             Vector3 mousePos;
             mousePos = Input.mousePosition;
             mousePos = Camera.main.ScreenToWorldPoint(mousePos);

             this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, 0);
     }

     private void OnMouseUp()
     {
        switch (itemType)
        {
            case 4:
                //rabbit milk 
                Instantiate(item5, this.transform.position, Quaternion.identity);
                break;
            case 3:
                //cycle
                Instantiate(item4, this.transform.position, Quaternion.identity);
                break;
            case 2:
                //guante
                Instantiate(item3, this.transform.position, Quaternion.identity);
                break;
            case 1:
                //Bun
                Instantiate(item2, this.transform.position, Quaternion.identity);
                break;
            case 0:
                //Bandana
                Instantiate(item1, this.transform.position, Quaternion.identity);
                break;
            default:
                print("Rare error kinda sussy");
                break;
        }
        Shelves.onlyOne = false;
        Destroy(gameObject);
     }

}
