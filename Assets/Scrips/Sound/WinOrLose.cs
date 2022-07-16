using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinOrLose : MonoBehaviour
{

    //Finale
    static public AudioSource musHopesNDreams;
    public AudioSource xmusHopesNDreams;
    static public AudioSource musDetermination;
    public AudioSource xmusDetermination;

    // Start is called before the first frame update
    void Start()
    {
        musHopesNDreams = xmusHopesNDreams;
        musDetermination = xmusDetermination;
    }
    static public void WinOrLoss(bool income)
    {
        if (income == false)
        {
            musHopesNDreams.Play();
        }
        else
        {
            musDetermination.Play();
        }
    }

}
