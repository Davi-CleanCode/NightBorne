using UnityEngine;

public class EnemyBase : MonoBehaviour {
    public int health = 50;
    public int damage = 10;

    public void TakeDamage(int dmg) {
        health -= dmg;
        if (health <= 0) {
            Die();
        }
    }

    void Die() {
        Destroy(gameObject);
    }
}