using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour {
    GameObject cam;
    Rigidbody rb;
    Vector3 t;
    public  LevelManager levelmanager;
    float hor;
    float x,y;
    int speed = 100,pos = 1;
    bool space = true;
    public ParticleSystem fire;
    public AudioSource Jump;
    public Text Speed;
    void Start () {
        cam = GameObject.Find("Main Camera");                      //Camera Object -.-
        rb = gameObject.GetComponent<Rigidbody>();                 // Rigidbody -.-
        t = cam.transform.position - this.transform.position;      // The Transform -.-
        x = 1;
        y = 0;
    }

    // Update is called once per frame
    void Update () {
        if (Input.GetKey(KeyCode.Escape)) { levelmanager.LoadLevel("Levels"); }
        //Ball Moves -.-
        hor = Input.GetAxis("Horizontal");                      //Right and Left Arrow -.-
                                                                

        if (Input.GetKey(KeyCode.UpArrow)) { x += 0.1f; fire.Play(); }

        if (Input.GetKey(KeyCode.DownArrow)) { x = 1; }

        if (x <= 0) { x = 1; }

        if (this.transform.position.y == 0.25f) { space = true; }

        if (Input.GetKey(KeyCode.Space) && space) { y += 10; fire.Play(); Jump.Play(); }

        if (this.transform.position.y > 1.5f)
            {
                space = false;
                rb.AddForce(new Vector3(-x, 0.2f, hor * 2) * Time.deltaTime * speed);
        }else
        {
            rb.AddForce(new Vector3(-x, y, hor * 2) * Time.deltaTime * speed);  //Force To Move The Ball -.-
        }

        

        

        if (this.transform.position.x < -30*pos) { speed +=50; pos++; }
        Speed.text = "Speed : " + ((x+(speed/100)*10)).ToString();
        if (this.transform.position.y <= -10)                            //if The Ball Is Down , You Will Lose -_-
            {
                levelmanager.LoadLevel("Lose");                           //Then Load The Lose SCene -.-
            }

        if (y >= 2) { y -= 10;}

        cam.transform.position = t + this.transform.position;         //Camera Look at Ball and Move after Ball -.- 
        
    }
}
