using UnityEngine;
using System.Collections;

public class CreateTitleButton : MonoBehaviour {
	static public bool isClient = false;
	static public string ip = "127.0.0.1";
	static public string port = "1192";

	public void OnGUI()
	{
		GUI.Label (new Rect(200, 20, 500, 100), "UnityChanのおにごっこ");
		GUI.Label (new Rect(200, 45, 100, 25), "ip address");
		ip = GUI.TextField (new Rect(200, 70, 100, 25), ip);
		GUI.Label (new Rect(300, 45, 100, 25), "port number");
		port = GUI.TextField (new Rect(300, 70, 100, 25), port);
		if (GUI.Button (new Rect (10, 10, 90, 90), "Client")) {
			isClient = true;
			Application.LoadLevel (1);
		}
		if (GUI.Button (new Rect (10, 110, 90, 90), "Master")) {
			isClient = false;
			Application.LoadLevel (1);
		}
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
