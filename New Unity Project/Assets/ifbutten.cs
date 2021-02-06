using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifbutten : MonoBehaviour
{
    static Renderer capsuleColor;
    static Color[] colorarr = new Color[4];

    void Start()
    {
        capsuleColor = gameObject.GetComponent<Renderer>();

        capsuleColor.material.color = new Color(1, 1, 1, 1);

        colorarr[0] = new Color(243 / 255f, 46 / 255f, 13 / 155f, 255 / 255f);//red
        colorarr[1] = new Color(238 / 255f, 185 / 255f, 35 / 155f, 255 / 255f);//yellow
        colorarr[2] = new Color(52 / 255f, 49 / 255f, 55 / 155f, 255 / 255f);//gray
        colorarr[3] = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);//white
    }


    public static void changeColor(bool c)
    { 
        if(c==true)
            capsuleColor.material.color = colorarr[Random.Range(0,3)];
        else
            capsuleColor.material.color = colorarr[3];
    }
}
