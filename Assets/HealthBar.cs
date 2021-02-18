using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class HealthBar : MonoBehaviour
{
    [Range(0, 100)]
    public int currentHealth;

    [Range(1, 100)]
    public int maximumHealth;

    public Slider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Slider>();
        maximumHealth = (int)healthBar.maxValue;
        currentHealth = maximumHealth;
        healthBar.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.K))
        {
            TakeDamage(10);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }

    }

    public void Reset()
    {
        healthBar.value = maximumHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.value = currentHealth;
    }
}
