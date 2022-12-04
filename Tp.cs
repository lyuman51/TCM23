using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tp : MonoBehaviour
{
    [SerializeField] Transform tp;

    [SerializeField] GameObject player;

    private void OnTriggerEnter(Collider other)
    {
      StartCoroutine(Teleport());
    }
    IEnumerator Teleport() 
    {
        yield return new WaitForSeconds(1);
        player.transform.position = new Vector3(
            tp.transform.position.x,
            tp.transform.position.y,
            tp.transform.position.z
        );
    }
}