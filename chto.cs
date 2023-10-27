using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chto : MonoBehaviour
{
    //йюйне рн уо
    public int health = 5;
    //йюйне рн кбк
    public int level = 1;
    //йюйне рн яохд
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
        health += level * 2;
        print("уЕОЕЬНВЙХ: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPostion = transform.position;
        newPostion.z += speed * Time.deltaTime;
        transform.position = newPostion;
        //он опхйнкс ядекюк, врнаш керек он Y!!!
        Vector3 newPostion2 = transform.position;
        newPostion2.y += speed * Time.deltaTime;
        transform.position = newPostion2;
    }
}
