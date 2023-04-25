using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetScript : MonoBehaviour
    {

        [SerializeField] private GameObject Snake;
        [SerializeField] private float length;
        private float L =0;
    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(Snake.transform.position, transform.position) < 5)
        {
            if(L == 0){
            StartCoroutine(Move());}
        }

    }

    private IEnumerator Move()
    {
         L = 0;
        Vector3 newpos = Snake.transform.position + new Vector3(Random.Range(-50,50),Random.Range(-50,50),Random.Range(-50,50));
       while(L < 1)
       {
        L+= (1 /length)* Time.deltaTime ;
        transform.position = Vector3.Slerp(transform.position, newpos, L );
        yield return null;
       }
       L=0;

    }
}
