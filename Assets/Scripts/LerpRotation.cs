using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpRotation : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        LookAt(player);
    }

    private void LookAt(GameObject lookObject)//Lerp
    {
        Vector3 direction = (lookObject.transform.position - transform.position);
        Quaternion newQuaternion = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, newQuaternion, 1f * Time.deltaTime);
    }
}
