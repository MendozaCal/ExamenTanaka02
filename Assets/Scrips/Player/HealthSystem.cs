using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    int life;
    void Update()
    {
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
