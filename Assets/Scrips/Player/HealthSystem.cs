using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    int life;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            RecibirDaņo(collision.gameObject.GetComponent<Damage>().GetDamage());
        }
    }
    private void RecibirDaņo(int value)
    {
        life -= value;
        if (life <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(3);
        }
    }
}
