using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcScript : MonoBehaviour
{
    // количество здоровья
    public int health = 5;
     // количество уровней
    public int level = 1;
    // скорость
    public float speed = 1.2f;
    // Start is called before the first frame update
    void Start()
    {
       health = health+level; // слаживает переменную health и level
       print("health " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
