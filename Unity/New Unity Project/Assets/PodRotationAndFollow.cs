using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PodRotationAndFollow : MonoBehaviour
{
    [SerializeField] private GameObject PodVisial;
    [SerializeField] private GameObject FollowObj;
    [SerializeField] private float FollowSpeed;
    [SerializeField] private float RotationSpeed;
    [SerializeField] private GameObject Boid;
    // Update is called once per frame
    void Update()
    {   
        transform.LookAt(Boid.transform);
        float dist = Vector3.Distance(transform.position, FollowObj.transform.position);
        transform.position = Vector3.Slerp(transform.position, FollowObj.transform.position, (dist/FollowSpeed) * Time.deltaTime);
        PodVisial.transform.Rotate((RotationSpeed/2 )* Time.deltaTime, RotationSpeed * Time.deltaTime, (RotationSpeed *2) * Time.deltaTime);
    }
}
