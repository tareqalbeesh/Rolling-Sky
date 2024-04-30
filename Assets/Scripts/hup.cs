using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hup : MonoBehaviour
{
    float y;
    public ParticleSystem bomfire;
    public ParticleSystem bomfire1;
    public ParticleSystem bomfire2;
    public ParticleSystem bomfire3;
    public ParticleSystem bomfire4;
    public ParticleSystem bomfire5;
    public AudioSource Bomb;
    public void Start()
    {
        y = 0;
    }

    public void Update()
    {
        if (this.transform.position.y <= -1)
        {
            y += 0.01f;
        }
        if (this.transform.position.y >= 0)
        {
            y -= 0.001f;
        }

        this.transform.Translate(new Vector3(0, y, 0));
    }


    public LevelManager levelmanager;

    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "destroy") { Destroy(gameObject); }
        else { 
        bomfire.Play(); bomfire1.Play(); bomfire2.Play(); bomfire3.Play(); bomfire4.Play(); bomfire5.Play();
        Bomb.Play();
        levelmanager.LoadLevel("Lose");                // Then You Will Lose -_-
        }
    }
}
