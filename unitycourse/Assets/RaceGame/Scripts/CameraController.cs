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
        //LateUpdate genellikle kamera takibinde kullanýlýr.
        //Update() fonksiyonundan sonra çaðrýlýr.
        //Özellikle kamera hareketi veya kameranýn nesneleri takip etmesi gibi durumlarda kullanýlýr.
        //Bu fonksiyon, diðer nesnelerin güncellendiði ve hareket ettiði bir zamanda kamera veya takip eden obje üzerindeki iþlemleri yapmak için idealdir.
               transform.position = player.transform.position + offset;
    }

    
    void Update()
    {
        //Smooth bir görüntü olmaz. Titreþim farkediliyor...
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
