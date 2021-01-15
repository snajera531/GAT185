using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int points = 0;
    public Material material;
    
    private void Start()
    {
        GetComponent<Renderer>().material = material;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Projectile"))
        {
            //add score to game
            Game.Instance.AddPoints(points);
        }

    }
}
