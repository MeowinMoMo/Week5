using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;

    public Transform firePoint;

    public float fireForce;

    public void Fire()
    {
       GameObject projectile = Instantiate(bullet, firePoint.position, firePoint.rotation);
      //  GameObject obj = objectPooler.current.GetPolledObject();
      //  if (obj == null) return;
      //  obj.transform.position = firePosition.position;
      //  obj.transform.protation = firePosition.position;
      //  obj.SetActive(true);

       Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
       rb.AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);

    }

}
