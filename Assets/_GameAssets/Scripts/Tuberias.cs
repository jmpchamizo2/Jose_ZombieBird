using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberias : MonoBehaviour {
    //Podremos editarla desde el editor
    [SerializeField] int speed = 3;

	
	void Start () {
        float factorPosicion = Random.RandomRange(-2, 2);
        this.transform.position = new Vector3(
            transform.position.x,
            transform.position.y + factorPosicion,
            transform.position.z);
    }
	

	void Update () {
        if (GameConfig.IsJugando())
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < -14)
        {
            Destroy(this.gameObject);
        }
    }
}
;