using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCreator : MonoBehaviour
{

    [SerializeField] private GameObject Obstacle;
    [SerializeField] private int AmountOfObstacles;
    // Start is called before the first frame update
    void Start()
    {
        
           while( AmountOfObstacles >0)
           {
                AmountOfObstacles-=1;
                GameObject Obby = Instantiate(Obstacle,transform.position+ new Vector3(Random.Range(-100,100),Random.Range(-100,100),Random.Range(-100,100)), Quaternion.identity);
                float Scale = Random.Range(5,20);
                Obby.transform.localScale = new Vector3(Scale,Scale,Scale);
           }
            
        
    }

}
