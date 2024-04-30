using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinalFloorbarrier : MonoBehaviour {
    public LevelManager levelmanager;
    public ParticleSystem bomfire;
    public ParticleSystem bomfire1;
    public ParticleSystem bomfire2;
    public ParticleSystem bomfire3;
    public ParticleSystem bomfire4;
    public ParticleSystem bomfire5;
    public AudioSource Bomb;
    float z = 0;
    // Use this for initialization
    void Start () {
        z = 0.01f;
	}

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
        if(this.tag == "Right") {
            this.transform.Translate(new Vector3(0, 0, z));
            if (this.transform.position.z <= 1) { z = -0.01f; }
            else if(this.transform.position.z >= 2.5f) { z = +0.01f; }
        }
        else if(this.tag == "Left") {
            this.transform.Translate(new Vector3(0, 0, z));
            if (this.transform.position.z >= -1) { z = -0.01f; }
            else if (this.transform.position.z <=-2.5) { z = +0.01f; }
        }
		
	}
}
