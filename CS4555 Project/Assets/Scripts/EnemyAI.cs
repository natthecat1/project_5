using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public Transform targetObj;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 1 * Time.deltaTime);
    }
}
