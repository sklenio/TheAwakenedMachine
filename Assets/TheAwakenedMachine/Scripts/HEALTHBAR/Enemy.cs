//this script is set on the enemy, giving it XP parameters, damage and death animation
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int  HP = 100; //this enemy has 100 HP
    public Animator animator;
    public Slider healthBar;

    [SerializeField]
    private GameObject dropPrefab;

    void Update()
    {
        healthBar.value = HP;
    }

    public void TakeDamage(int damageAmount) //offers life, sentences to death
    {
        HP -= damageAmount; // HP = HP - damage
        if(HP <=0) //death sentence
        {
            Debug.Log("Enemy.cs: Enemy's HP is 0.");
            animator.SetTrigger("death"); // animation of death
            GetComponent<Collider>().enabled = false;
            healthBar.gameObject.SetActive(false); // healthbar disappears
            //gameObject.SetActive(false); // enemy unit either disappears
            Destroy(gameObject, 2); //or destroys
            Debug.Log("Enemy.cs: The enemy has disappeared.");
            Instantiate(dropPrefab, transform.position, transform.rotation); //drop after death
            Debug.Log("Enemy.cs: The enemy has dropped the item." + dropPrefab);
            

        }
        else
        {
            animator.SetTrigger("damage"); //shows damage animation
            Debug.Log("Enemy.cs: The enemy is showing damage animation.");
        }
    }
}
