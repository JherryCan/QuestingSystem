﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuestSystem;
public class Test : MonoBehaviour {
	public GameObject item;
	// Use this for initialization
	void Start () {
		IQuestObjective qo = new CollectionObjective ("Gather", 10, item, "Gather 10 meat!");
		print (qo.ToString ());

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
