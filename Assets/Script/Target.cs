using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {
    public ParticleSystem Particle;
    public float lifeTime = 5.0f;
    void start()
    {
        Particle = GetComponent<ParticleSystem>();
        Particle.Stop();
    }

    public void TakeDamage( RaycastHit hit)

    {
        Particle.transform.position = hit.point;
        Particle.Play();
        //yield return new WaitForSeconds(lifeTime);
        //Particle.Stop();
        //GlobalScore.CurrentScore += 50;
        Debug.Log(string.Format("Destroyed YYYYYYYYYYY......"));
        //Destroy(this.gameObject, 1f);

    }
}


/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public float health = 40f;
    public AudioClip cubeexplosion;
    public AudioSource CubeExplode;
    public ParticleSystem Particle;

    void Start()
    {
        //     CubeExplode = GetComponent<AudioSource>();
    }

    public void TakeDamage(float amount)

    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }

    }


    void Die()
    {
        Particle.Play();
        CubeExplode.PlayOneShot(cubeexplosion, 5f);


        Destroy(this.gameObject, 1f);
    }
}

    */