using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float enemySpeed = 19.0f;
    private GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        MoveTowards();
    }

    private void MoveTowards()
    {
        Vector3 direction = (player.transform.position - transform.position);
        if (direction.magnitude > 2)
        {
            transform.position += direction.normalized * enemySpeed * Time.deltaTime;
        }
    }

    private void LookAt(GameObject lookObject)
    {
        Vector3 direction = (lookObject.transform.position - transform.position);
        Quaternion newQuaternion = Quaternion.LookRotation(direction);
        transform.rotation = newQuaternion;
    }
}