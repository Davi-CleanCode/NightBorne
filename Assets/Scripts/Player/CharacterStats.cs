using UnityEngine;

[System.Serializable]
public class CharacterStats {
    public int maxHealth = 100;
    public int currentHealth;

    public int attackPower = 10;

    public CharacterStats() {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int dmg) {
        currentHealth -= dmg;
        if (currentHealth < 0) currentHealth = 0;
    }

    public void Heal(int amount) {
        currentHealth += amount;
        if (currentHealth > maxHealth) currentHealth = maxHealth;
    }
}