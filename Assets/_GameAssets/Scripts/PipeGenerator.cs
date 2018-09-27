using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour {
    [SerializeField] private Transform tuberia;
    [SerializeField] private float ratioTuberias = 2f;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GeneratePipe", 0, ratioTuberias);

    }
	
	
	void Update () {
		
	}

    void GeneratePipe()
    {
        if (GameConfig.IsJugando())
        {
            Instantiate(tuberia, transform.position, Quaternion.identity);
        }
        
    }
}
