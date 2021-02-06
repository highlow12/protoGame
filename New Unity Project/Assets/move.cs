using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objects = new GameObject[5];
    public int position = 0;

    int a;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(objects.Length);
        a = objects.Length;
        position--;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, objects[position].transform.position, speed * Time.deltaTime);
        if (Input.anyKeyDown)
        {
            
            
            if (position <=0)
            {
                position = a-1;
            }
            else
            {
                position--;
            }

            

        }
        if (transform.position==objects[0].transform.position)
        {
            //ifbutten.changeColor(true);
        }
        else
        {
            ifbutten.changeColor(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        ifbutten.changeColor(true);
        Debug.Log("enter");
    }
}

