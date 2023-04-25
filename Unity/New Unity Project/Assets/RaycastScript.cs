using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{

    [SerializeField] private MonoBehaviour OnControl, MovementBoid;
    [SerializeField] private MonoBehaviour OnLoseControl, MovementPlayer;
    
    private RaycastHit hit;
    [SerializeField] private LayerMask layer;
    // Update is called once per frame
    void Update()
    {
         if(Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, layer))
            {
                OnControl.enabled = true;
                MovementBoid.enabled = true;
                MovementPlayer.enabled =false;
                OnLoseControl.enabled = false;
            }
        }
        if(Input.GetKeyDown(KeyCode.Z))
        {
            transform.parent = null;
                 MovementBoid.enabled = false;
                 MovementPlayer.enabled = true;
                OnControl.enabled = false;
                OnLoseControl.enabled = true;
        }
    }
}
