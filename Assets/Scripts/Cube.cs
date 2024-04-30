using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cube : MonoBehaviour
{
    public LevelManager levelmanager;
    public ParticleSystem bomfire;
    public ParticleSystem bomfire1;
    public ParticleSystem bomfire2;
    public ParticleSystem bomfire3;
    public ParticleSystem bomfire4;
    public ParticleSystem bomfire5;
    public AudioSource Bomb;

    private void OnTriggerEnter(Collider col)
    {
        if (this.tag == "End1")
        {
            levelmanager.LoadLevel("Level2");
        }
        else if (this.tag == "End2")
        {
            levelmanager.LoadLevel("Level3");
        }
        else if (this.tag == "End3")
        {
            levelmanager.LoadLevel("Level1");
        }
        if (col.tag == "destroy") { Destroy(gameObject); }
        else
        {
            Bomb.Play();
            bomfire.Play(); bomfire1.Play(); bomfire2.Play(); bomfire3.Play(); bomfire4.Play(); bomfire5.Play();
            levelmanager.LoadLevel("Lose");                // Then You Will Lose -_- 
        }
    }
}
