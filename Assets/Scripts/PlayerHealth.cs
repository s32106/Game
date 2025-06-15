using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float maxHealth = 100;
    [SerializeField] public float health = 100;
    public Animator anim;

    public TMP_Text healthText;

    public bool isDead = false;


    private void Start()
    {
        anim = GetComponent<Animator>();

    }

    public void TakeDamage(float damage)
    {
        health = health - damage;
        if (health < 0)
        {
            health = 0;

        }
        if (health > maxHealth)
        {
            health = maxHealth;
        }
        if (health == 0)
        {
            isDead = true;
            anim.SetTrigger("isDead");
        }
    }

}
