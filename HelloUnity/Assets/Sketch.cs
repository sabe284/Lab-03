﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    public GameObject myPrefab;

	void Start () {

        int totalCubes = 30;

        float totalDistance = 2.9f;

        // SIN() DISTRIBUTION
        for (int i = 0; i < totalCubes; i++)
        {
            float perc = i / (float)totalCubes;

            float sin = Mathf.Sin(perc * Mathf.PI / 2);

            float x = 1.8f + sin * totalDistance;
            float y = 5.0f;
            float z = 0.0f;

            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            newCube.GetComponent<CubeScript>().SetSize(.45f * (1.0f - perc));
            newCube.GetComponent<CubeScript>().RotateSpeed = .2f + perc * 4.0f;
        }
    }
	
	
	void Update () {
		
	}
}


// LINEAR DISTRIBUTION
//for (int i = 0; i < totalCubes; i++)
//{
//    float perc = i / (float)totalCubes;

//    float x = perc * totalDistance;
//    float y = 3.0f;
//    float z = 0.0f;

//    var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
//    newCube.GetComponent<CubeScript>().SetSize(1.0f - perc);
//    newCube.GetComponent<CubeScript>().RotateSpeed = perc; // Random.value;
//}
