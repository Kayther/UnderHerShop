using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFlying : MonoBehaviour
{
    public GameObject item1;
    public GameObject item2;
    public GameObject item3;
    public GameObject item4;
    public GameObject item5;

    public int itemType;

    SpriteRenderer sr;
    public Sprite NSFWIMG;
    public Sprite SFWIMG;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        if (VariableManager.NSFW == true)
        {
            sr.sprite = NSFWIMG;
        }
        else
        {
            sr.sprite = SFWIMG;
        }
    }

    private void OnMouseDown()
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

    }
}
