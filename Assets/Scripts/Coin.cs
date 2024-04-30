using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour {
    public LevelManager levelmanager;
    public CountCoin count;
    public Text Score;
    public AudioSource tone;
    float y = 0;
    bool up = false;
    void Update()
    {
        transform.Rotate (new Vector3(0,10,0));
        Score.text = "Score : " + count.count.ToString();
        if(up == true) {
            this.transform.Translate(new Vector3(0, y, 0));
            y += 0.005f;
        }

        if(this.transform.position.y >= 3) { Destroy(gameObject); }

    }

    public void OnTriggerEnter(Collider col)
    {
        if (col.tag != "destroy")
        {
            tone.Play();
            count.count++;
            //Destroy(gameObject);
            up = true;
            if (count.count >= 20) { levelmanager.LoadLevel("Win"); }
        }
    }
}
