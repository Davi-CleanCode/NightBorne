using UnityEngine;
using UnityEngine.UI;

public class UIHealth : MonoBehaviour {
    public Slider slider;
    public CharacterStats playerStats;

    void Update() {
        slider.value = (float)playerStats.currentHealth / playerStats.maxHealth;
    }
}