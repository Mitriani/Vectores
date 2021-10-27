using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enum : MonoBehaviour
{
    private float enemySpeed = 19.0f;
    private GameObject player;
    enum Comportamiento { Seguir, Mirar }
    [SerializeField] private Comportamiento behaviour;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Behaviour();
    }

    private void MoveTowards()
    {
        Vector3 direction = (player.transform.position - transform.position);
        if (direction.magnitude > 2)
        {
            transform.position += direction.normalized * enemySpeed * Time.deltaTime;
        }
    }

    private void LookAt(GameObject lookObject)//Lerp
    {
        Vector3 direction = (lookObject.transform.position - transform.position);
        Quaternion newQuaternion = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, newQuaternion, 1f * Time.deltaTime);
    }

    private void Behaviour()
    {
        switch (behaviour)
        {
            case Comportamiento.Seguir:
                MoveTowards();
                break;
            case Comportamiento.Mirar:
                LookAt(player);
                break;
        }
    }
}
