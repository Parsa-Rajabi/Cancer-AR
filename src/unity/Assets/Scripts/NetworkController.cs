using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkController : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started Photon");
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Cloud Region is " + PhotonNetwork.CloudRegion);
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("Once per frame");
    }
}
