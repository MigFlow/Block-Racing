using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 4;
    public int currentHealth;

    public HealthBar healthBar;

    // Spwan Position (Position where the player was set while modeling the level)
    public Rigidbody rb;
    public Quaternion FirstTransform;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetHealth(maxHealth);

        // speichern der Spanwn position
        rb = this.GetComponent<Rigidbody>();
        FirstTransform = transform.rotation;
        Debug.Log(FirstTransform);

    }

    public void TakeDamage(int damage)
    {
        currentHealth -= 1;
        healthBar.SetHealth(currentHealth);
    }

    // TODO: geht noch nicht wie es soll --> sie Physik soll nicht unterborchen werden
    public void ResetSpwanOrientation()
    {
        rb.isKinematic = true;
        transform.rotation = FirstTransform;
        rb.isKinematic = false;
    }

}
