using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float fireRate = 0.1f;
    int ammo = 100;
    float fireTimer = 0;
    public GameObject projectile;

    void Start()
    {
        
    }

    void Update()
    {
        fireTimer += Time.deltaTime;
        /*if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            GameObject _projectile = Instantiate(projectile, transform.position, Quaternion.identity);
            _projectile.GetComponent<Projectile>().Fire(ray.direction);
        }*/
    }

    public bool Fire(Vector3 position, Vector3 direction)
    {
        if(fireTimer >= fireRate)
        {
            fireTimer = 0;
            GameObject _projectile = Instantiate(projectile, position, Quaternion.identity);
            _projectile.GetComponent<Projectile>().Fire(direction);

            return true;
        }

        return false;
    }
}
