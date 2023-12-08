using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    private Vector3 offset1 = new Vector3(0,7.5f,-10f);
    private Vector3 offset2 = new Vector3(0, 3f, 0);
    private Vector3 offset;
    private bool camChange = false;


    private void Start()
    {
        offset = offset1;
    }
    void LateUpdate()
    {
        //LateUpdate genellikle kamera takibinde kullan�l�r.
        //Update() fonksiyonundan sonra �a�r�l�r.
        //�zellikle kamera hareketi veya kameran�n nesneleri takip etmesi gibi durumlarda kullan�l�r.
        //Bu fonksiyon, di�er nesnelerin g�ncellendi�i ve hareket etti�i bir zamanda kamera veya takip eden obje �zerindeki i�lemleri yapmak i�in idealdir.
               transform.position = player.transform.position + offset;
    }

    
    void Update()
    {
        //Smooth bir g�r�nt� olmaz. Titre�im farkediliyor...
        //transform.position = player.transform.position + offset;

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (offset == offset1)
            {
                offset = offset2;
            }
            else
            {
                offset = offset1;
            }
        }
    }
    
}
