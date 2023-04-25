using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraNew : MonoBehaviour
{
    [SerializeField] private Transform Lookat;
    [SerializeField] private Transform CameraHolder;
    [SerializeField] private float length, L;
    
    

    private void OnEnable()
    {
        MoveToPod();
        L=0;
        transform.parent = CameraHolder;
    }

    public void MoveToPod()
    {
        StartCoroutine(MovePod());
    }

    private void Update()
    {
        L +=1 * Time.deltaTime;
        transform.rotation = Quaternion.Lerp(transform.rotation, CameraHolder.rotation, L);
    //    transform.LookAt(Lookat);
    }

    private IEnumerator MovePod()
    {
        float T = 0;
        while (T < 1 )
        {
            T+= (1  / length) * Time.deltaTime;
            transform.position = Vector3.Slerp(transform.position, CameraHolder.position, T);
            yield return null;  
        }
    }


}
