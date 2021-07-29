using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointAI : MonoBehaviour //pascalCasing 
{
    [SerializeField] private float speedX = 1f; //camcel casing 
    [SerializeField] private float speedY = 1f; //camcel casing
    [SerializeField] private GameObject goal; 
    // Start is called before the first frame update
    void Start()
    {

        // ==equal to 
        //!- not equal t0
        // < less then
        // >  grater then ]
        // <= less then or equal to 
        // >= greater the or equal to
        // && and- both have to be ture 
        // LL 


    // task move ai to as scoand goal; after reaching the first 
   



        // Update is called once per frame
        void Update()
    {
            //float distance = (goal.transform.position - transform.position).mangnitude;

            float distance2 = Vector2.Distance(transform.position, goal.transform.position);



       
       
                if (distance2 > 0.1f)
            {


            }
        //the direction from A to B 
        //direction = B - A 
        Vector2 direction = (goal.transform.position - transform.position).normalized;
        Vector2 aiPostion = transform.position;
        aiPostion += direction * speedX * Time.deltaTime;
        transform.position = aiPostion;
        
    }
}
