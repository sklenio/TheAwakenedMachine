//this script contains the characters' main damage dealing attack

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereCastWeapon : MonoBehaviour
{
    [SerializeField]
    private float collisionRange = 0.01f; // the range of collision
    public int damageAmount = 20; 
    public AudioSource damageSound; // plays the damage dealing sound

    List<GameObject> TemporaryList = new List<GameObject>();

    void Update()
    {
        // Den här raden testar OM det är några objekt som hamnar er inom collisionRange
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, collisionRange);
        
         // här går vi igenom varje objekt i den listan 
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.gameObject.CompareTag("enemy") //and if the weapon touches the enemy tag's colliderS
            //&& TemporaryList.Contains(gameObject)
            )
            {
                hitCollider.GetComponent<Enemy>().TakeDamage(damageAmount); //go to another script Enemy.cs and implement TakeDamage to the foe
                damageSound.Play();
                Debug.Log("SphereCastWeapon.cs: Your SphereCast collider has attacked the enemy | " + hitCollider.gameObject.name + " |. Dmg " + damageAmount + " inflicted!");
            }
        }
    }
}
