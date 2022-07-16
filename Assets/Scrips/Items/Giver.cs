using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giver : MonoBehaviour
{
    //Esto es un item invisible que desaparece y le da el objeto
    public int itemType;
    void Start()
    {
        Destroy(gameObject,0.1f);
    }

    void OnTriggerEnter2D(Collider2D collide)
    {
        if (collide.gameObject.CompareTag("Client"))
        {
            Cliente giveVar = collide.transform.GetComponent<Cliente>();
            switch (itemType)
            {
                case 4:
                    //rabbit milk 
                    giveVar.ReciveItem(4);
                    Destroy(gameObject);
                    break;
                case 3:
                    //cycle
                    giveVar.ReciveItem(3);
                    Destroy(gameObject);
                    break;
                case 2:
                    //guante
                    giveVar.ReciveItem(2);
                    Destroy(gameObject);
                    break;
                case 1:
                    //Bun
                    giveVar.ReciveItem(1);
                    Destroy(gameObject);
                    break;
                case 0:
                    //Bandana
                    giveVar.ReciveItem(0);
                    Destroy(gameObject);
                    break;
                default:
                    print("Rare error kinda sussy");
                    break;
            }
        }
    }

}
