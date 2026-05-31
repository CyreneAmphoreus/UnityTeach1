
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private int health = 3;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            UnderAttack();
        }
    }

    private void UnderAttack()
    {
        health--;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
