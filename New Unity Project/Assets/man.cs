using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class man : MonoBehaviour
{
    private Vector3 direction;

    public void Shoot(Vector3 direction)

    {

        this.direction = direction;

        Invoke("DestroyBullet", 5f);

    }



    public void DestroyBullet()

    {

        poolManager.ReturnObject(this);

    }



    void Update()

    {
        Vector3 vec = direction;
        transform.Translate(direction);

    }

}

