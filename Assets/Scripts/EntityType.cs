using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityType : MonoBehaviour
    {
     // AttackType definition
     public enum AttackTypeEnum{SingleTarget, AOE};

     // public fields
     public string entityName;
     public float health;
     public float maxHealth;
     public float damage;
     public float range;
     public float attackCooldown;
     public AttackTypeEnum attackType;
     public string targetType;

     // private fields

     // Start is called before the first frame update
     void Start()
        {
         
        }

     // Update is called once per frame
     void Update()
        {
         // TODO: Attempt to attack on interval determined by attackCooldown
        }

     // Returns a list of valid targets in range (NULL if none)
     EntityType[] getTargetsInRange()
        {
         // TODO
         return null;
        }

     // Returns the closest valid target, depends on getTargetsInRange (NULL if none)
     EntityType getClosestTarget()
        {
         // TODO
         return null;
        }

     // Attempts to perform an attack on valid target(s)
     void attack()
        {
         // TODO

         // find a target

         // if target is not null:
            // remove health from the target
            // (maybe we have a "lose health" function that we call?)
            // (that way we could (hypothetically) add animations or something. eventually.)
         // else:
            // reset attack cooldown timer
        }
    }