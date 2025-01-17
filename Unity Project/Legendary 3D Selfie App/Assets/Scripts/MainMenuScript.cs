﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuScript : MonoBehaviour {

	private ManagerScript manager;

    void Start ()
    {
        manager = GameObject.Find("GameManagerObject").GetComponent<ManagerScript>();	
		StartCoroutine ("Wait");
	}

    IEnumerator Wait()
	{
		yield return new WaitForSeconds (1.5f);
		manager.LoadNextScene(SceneManager.GetActiveScene());
    }
}
