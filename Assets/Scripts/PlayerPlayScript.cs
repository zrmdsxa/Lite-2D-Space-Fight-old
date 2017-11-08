using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerPlayScript : NetworkBehaviour
{

    public GameObject z7interceptor;

    // Use this for initialization
    void Start()
    {
		if(isLocalPlayer){
			transform.GetChild(0).gameObject.SetActive(true);
			transform.GetChild(1).gameObject.SetActive(true);
		}
		Debug.Log("player :"+connectionToClient);
    }

	void HideUI(){
		transform.GetChild(0).gameObject.SetActive(false);
		transform.GetChild(1).gameObject.SetActive(false);
	}

    public void SpawnZ7Interceptor()
    {
        
		//GameObject go = Instantiate(z7interceptor);
		//NetworkServer.Spawn(go);
		//GameObject go = Instantiate(z7interceptor);
		//Debug.Log(isLocalPlayer);
		if(isLocalPlayer){
			HideUI();
			CmdSpawnZ7Interceptor();
		}
		
		
    }

    [Command]

    public void CmdSpawnZ7Interceptor()
    {
        Debug.Log("spawn z7");
        GameObject go = Instantiate(z7interceptor);
		NetworkServer.SpawnWithClientAuthority(go,gameObject);
		//Debug.Log(connectionToClient);
        //NetworkServer.Spawn(go);
		//Destroy(go);
        //Debug.Log(connectionToServer);


    }


}
