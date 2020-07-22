﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform spawnPos;
	public GameObject spawnee;
	
	void Update ()
    {
		Instantiate(spawnee, spawnPos.position, spawnPos.rotation);
	}
}
