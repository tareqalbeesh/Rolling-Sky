using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Smile : MonoBehaviour {
	// Update is called once per frame
	void Update () {
        this.transform.Translate(new Vector3(0, 0, -2));
        this.transform.Rotate(new Vector3(0, 0, 1));
        if (this.transform.position.y <= -100)
            Destroy(gameObject);
    }
}
