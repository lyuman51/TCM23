using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move : MonoBehaviour
{
    public Vector3 mv1;
    public Vector3 mv2;
    public Vector3 jump;

    public Vector3 rote;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKey(KeyCode.A))
    {
      mv2.x = -0.06f;
      transform.Translate(mv2);
    }  

    if(Input.GetKey(KeyCode.D))
    {
      mv2.x = 0.06f;
      transform.Translate(mv2); 
    }

     if(Input.GetKey(KeyCode.Space))
    {
      jump.y = 0.07f;
      transform.Translate(jump);
    }
  }
}