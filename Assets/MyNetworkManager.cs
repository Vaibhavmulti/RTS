using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MyNetworkManager :NetworkManager {
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MyStartHost()
    {
        Debug.Log("Starting host at " + Time.timeSinceLevelLoad);
        OnStartHost();
    }

    override public void OnStartHost()
    {
        Debug.Log("Host started at " + Time.timeSinceLevelLoad);
    }

    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Client connected " + Time.timeSinceLevelLoad);
    }

    public override void OnStartClient(NetworkClient client)
    {
        Debug.Log("Client started " + Time.timeSinceLevelLoad);
    }
}
