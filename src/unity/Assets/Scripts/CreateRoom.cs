using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoom : MonoBehaviourPunCallbacks
{
    [SerializeField] private Text roomName;

    
    public void onClick_CreateRoom()
    {
        Debug.Log("button clicked");
        // if not connected, do not create room
        if (!PhotonNetwork.IsConnected)
        {
            Debug.Log("Not connected");
            return;
        }

        RoomOptions options = new RoomOptions();
        options.MaxPlayers = 4;
        TypedLobby typedLobby = new TypedLobby(roomName.text, LobbyType.Default);
        // check to make sure room name is not empty
        if (roomName.text.Length > 0)
        {
            PhotonNetwork.JoinOrCreateRoom(roomName.text, options, typedLobby);
            PhotonNetwork.LoadLevel("gameplay");
        }
        else
        {
            Debug.Log("Enter a room name first");
        }
    }

    //callback function for if we fail to create a room. Most likely fail because room name was taken.
    public override void OnCreateRoomFailed(short returnCode, string message)
    {
        Debug.Log("Failed to create room... trying again");
    }

    public override void OnCreatedRoom()
    {
        Debug.Log("Room created successfully " + PhotonNetwork.CurrentRoom.Name);
    }
}