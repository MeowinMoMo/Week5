// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Projectile : MonoBehaviour
// {
//     public float projectilespeed;
//     private Rigidbody2D rb;

//     private void OnEnable()
//     {
//         If(rb != null)
//         {
//             rb.velocity - Vector2.up * projectileSpeed;
//         }
//         Invoke("Disable", 2f);
//     }
    
//     void Start()
//     {
//         rb = GetComponent<Rigidbody2D>();
//         rb.velocity - Vector2.up * projectileSpeed;

//     }

//     void Disable()
//     {
//         gameObject.SetActive(false);
//     }

//     private void OnDisable()
//     {
//         cancelInvoke();
//     }
// }
