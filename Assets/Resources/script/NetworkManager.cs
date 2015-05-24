﻿using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {
	public GameObject objectPrefab;
	string ip = CreateTitleButton.ip;
	string port = CreateTitleButton.port;
	bool connected = false;
	
	private void CreatePlayer()
	{
		Network.Instantiate(objectPrefab, objectPrefab.transform.position, objectPrefab.transform.rotation, 1); 
	}

	public void OnConnectedToServer()
	{    
		connected = true;
		CreatePlayer ();
	}
	
	public void OnServerInitialized()
	{
		connected = true;
		CreatePlayer ();
	}


	void Start () {
		if (CreateTitleButton.isClient) {
			Network.Connect (ip, int.Parse (port));
		} else {
			Network.InitializeServer (10, int.Parse (port), false);
		}
	}
	void Update () {}


}
