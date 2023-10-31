using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystemEnemy : MonoBehaviour
{
    [SerializeField]
    int life;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PlayerBullet"))
        {
            RecibirDa�o(collision.gameObject.GetComponent<Damage>().GetDamage());
        }
    }
    private void RecibirDa�o(int value)
    {
        life -= value;
        if (life <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
