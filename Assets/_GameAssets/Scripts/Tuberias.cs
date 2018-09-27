using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuberias : MonoBehaviour {
    //Podremos editarla desde el editor
    [SerializeField] int speed = 3;

	
	void Start () {
        float factorPosicion = Random.Range( - GameConfig.GetPuntuacion() * 0.5f, GameConfig.GetPuntuacion() * 0.5f);
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