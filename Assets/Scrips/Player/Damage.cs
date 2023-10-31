using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    [SerializeField]
    int life;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyUp") || collision.gameObject.CompareTag("Enemyright") || collision.gameObject.CompareTag("BulletEnemy"))
        {
            RecibirDaño(collision.gameObject.GetComponent<Damage>().GetDamage());
        }
    }

    private void RecibirDaño(int value)
    {
        life -= value;
        if (life <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(3);
        }
    }
}
