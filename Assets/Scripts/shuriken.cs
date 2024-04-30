using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuriken : MonoBehaviour {
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
        if (col.tag == "destroy") { Destroy(gameObject); }
        else
        {
            bomfire.Play(); bomfire1.Play(); bomfire2.Play(); bomfire3.Play(); bomfire4.Play(); bomfire5.Play();
            Bomb.Play();
            levelmanager.LoadLevel("Lose");                // Then You Will Lose -_-
        }
    }
    // Update is called once per frame
    void Update () {
        this.transform.Translate(new Vector3(0, 0, 0.1f));
	}
}
