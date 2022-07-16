using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Calendario : MonoBehaviour
{
    public GameObject tick;

    public Vector2[] posArray;

    // Start is called before the first frame update
    void Start()
    {
        posArray = new Vector2[20];

        posArray[0] = new Vector2(12.6249f,5.7481f);
        posArray[1] = new Vector2(19.87f, 5.24f);
        posArray[2] = new Vector2(-24.12f, 0.27f);
        posArray[3] = new Vector2(-16.88f, -0.3f);
        posArray[4] = new Vector2(-9.64f, -0.48f);
        posArray[5] = new Vector2(-2.377f, -0.928f);
        posArray[6] = new Vector2(4.87f, -1.26f);// nuevo
        posArray[7] = new Vector2(12.12f, -1.74f); // mal
        posArray[8] = new Vector2(19.373f, -2f);
        posArray[9] = new Vector2(-24.377f, -7f);
        posArray[10] = new Vector2(-17.13f, -7.5f);
        posArray[11] = new Vector2(-9.9f, -7.75f);
        posArray[12] = new Vector2(-2.628f, -8.25f);
        posArray[13] = new Vector2(4.628f, -8.542f);
        posArray[14] = new Vector2(11.87f, -9f);
        posArray[15] = new Vector2(19.125f, -9.23f);
        posArray[16] = new Vector2(-24.88f, -14.27f);
        posArray[17] = new Vector2(-17.63f, -14.83f);
        posArray[18] = new Vector2(-10.378f, -15.026f);
        posArray[19] = new Vector2(-3.124f, -15.492f);


        /*
         Instantiate(tick, posArray[0], Quaternion.identity); //ta bien 1

        Instantiate(tick, posArray[1], Quaternion.identity); //ta bien 2

        Instantiate(tick, posArray[2], Quaternion.identity); //ta bien 3

        Instantiate(tick, posArray[3], Quaternion.identity); //ta bien 4

        Instantiate(tick, posArray[4], Quaternion.identity); //ta bien 5

        Instantiate(tick, posArray[5], Quaternion.identity); //nuevo 6

        Instantiate(tick, posArray[6], Quaternion.identity); //ta bien 7

        Instantiate(tick, posArray[7], Quaternion.identity); //ta bien 8

        Instantiate(tick, posArray[8], Quaternion.identity); //ta bien 9

        Instantiate(tick, posArray[9], Quaternion.identity); //ta bien 10

        Instantiate(tick, posArray[10], Quaternion.identity); //ta bien 11

        Instantiate(tick, posArray[11], Quaternion.identity); //ta bien 12

        Instantiate(tick, posArray[12], Quaternion.identity); //ta bien 13

        Instantiate(tick, posArray[13], Quaternion.identity); //ta bien 14

        Instantiate(tick, posArray[14], Quaternion.identity); //ta bien 15

        Instantiate(tick, posArray[15], Quaternion.identity); //ta bien 16

        Instantiate(tick, posArray[16], Quaternion.identity); //ta bien 17

        Instantiate(tick, posArray[17], Quaternion.identity); //ta bien 18

        Instantiate(tick, posArray[18], Quaternion.identity); //ta bien 19

        Instantiate(tick, posArray[19], Quaternion.identity); //ta bien 20*/

        for (int i = 0; i < VariableManager.dayCount - 2; i++)
        {
                Instantiate(tick, posArray[i], Quaternion.identity);
        }

        StartCoroutine(writing());
    }
    public IEnumerator writing()
    {
        yield return new WaitForSeconds(2.0f);
        Instantiate(tick, posArray[VariableManager.dayCount-2], Quaternion.identity);
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene("Home");
    }
}
