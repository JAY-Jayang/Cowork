// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using Photon.Pun;
// using Photon.Realtime;

// public class NetworkManager : MonoBehaviourPunCallbacks
// {
// 	string networkState;

// 	void Start() => PhotonNetwork.ConnectUsingSettings();

// 	public override void OnConnectedToMaster() =>   // 서버 연결
// 		PhotonNetwork.JoinLobby();                  // 로비 접속

// 	public override void OnJoinedLobby() =>         
// 		PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions { MaxPlayers = 4 }, null);   // 방만들기

// 	void Update()
// 	{
// 		string curNetworkState = PhotonNetwork.NetworkClientState.ToString();
// 		if (networkState != curNetworkState) 
// 		{
// 			networkState = curNetworkState;
// 			print(networkState);                // 연결상태 출력
// 		}
// 	}
// }

/*연결이 실패할 경우 PhotonServerSetting의 IP왁인, 트레이 아이콘의 서버가 작동중인지 확인, 포트 포워딩 확인, 방화벽 확인*/