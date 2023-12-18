//this script allows to attack enemy with a weapon collider


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    public int damageAmount = 20;
    
    private void OnTriggerEnter(Collider other) //when triggering the collider
    {
        if(other.gameObject.CompareTag("enemy")) //and if the colliders tag is Enemy
        {
            Debug.Log("WeaponDamage.cs: Your weapon has triggered the enemy's collider.");
            other.GetComponent<Enemy>().TakeDamage(damageAmount); //then go to other script Enemy.cs and implement TakeDamage to deal damage to an enemy
            Debug.Log("WeaponDamage.cs: Your weapon has damaged the enemy.");
        }
    }
}
