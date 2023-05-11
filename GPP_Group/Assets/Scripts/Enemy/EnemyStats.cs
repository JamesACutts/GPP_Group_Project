using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats
{
    [SerializeField]
    private int damage;
   
    private void Start()
    {
        InitVariables();
    }
    public void DealDamage(CharacterStats statsToDamage)
    {
        statsToDamage.TakeDamage(damage);
    }

    public override void Die()
    {
        base.Die();
        Destroy(gameObject);
    }
    public override void InitVariables()
    {
        maxHealth = 30;
        SetHealthTo(maxHealth);
        isDead = false;

        damage = 3;
        attackSpeed = 1f;
    }

}
