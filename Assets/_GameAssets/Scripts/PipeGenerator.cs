using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour {
    [SerializeField] Transform tuberia;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GeneratePipe", 0, 2);

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
