using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dayController : MonoBehaviour
{
    private int gunSayac,aySayac, yilSayac;
    public Text takvim;
    // Start is called before the first frame update
    void Start()
    {
        gunSayac = 1;
        aySayac = 11;
        yilSayac = 1;
        takvim.text = yilSayac + ". yil   " + aySayac + ". ay   "+ gunSayac+".gun   ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextDay()
    {
        gunSayac++;
        if (gunSayac == 31)
        {
            gunSayac = 1;
            aySayac++;
        }
        if (aySayac == 13)
        {
            aySayac = 1;
            yilSayac++;
        }

        takvim.text = yilSayac + ". yil   " + aySayac + ". ay   "+ gunSayac+".gun   ";
        
    }
}
