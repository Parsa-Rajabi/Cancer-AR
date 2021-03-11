using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ModelSpawning : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    private void Start()
    {
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.ConnectUsingSettings();
        Debug.Log("Started!");
    }
    
    public override void OnConnectedToMaster() //Callback function for when the first connection is established successfully.
    {
        Debug.Log("Cloud Region is " + PhotonNetwork.CloudRegion);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Once per frame");
    }
}
