using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour {
	public GameObject objectPrefab;
	public static Object unitychan;
	string ip = "127.0.0.1";
	string port = "1192";
	bool connected = false;
	
	private void CreatePlayer()
	{
		//DontDestroyOnLoad(objectPrefab);
		connected = true;
		Application.LoadLevel (1);
		//DontDestroyOnLoad(Network.Instantiate(objectPrefab, objectPrefab.transform.position, objectPrefab.transform.rotation, 1));
		unitychan = Network.Instantiate(objectPrefab, objectPrefab.transform.position, objectPrefab.transform.rotation, 1); 
		DontDestroyOnLoad (unitychan);
	}
	
	public void OnConnectedToServer()
	{
		CreatePlayer();
	}
	
	public void OnServerInitialized()
	{
		CreatePlayer();
	}
	
	
	public void OnGUI()
	{
		if( !connected)
		{
			if( GUI.Button( new Rect( 10, 10, 90, 90), "Client"))
			{    
				Network.Connect(ip, int.Parse(port) ); 
			}
			if( GUI.Button( new Rect(10, 110, 90, 90), "Master"))
			{    
				Network.InitializeServer(10, int.Parse(port), false);    
			}
		}
	}

	void Start () {
		DontDestroyOnLoad (this);
	}
	void Update () {}
}
