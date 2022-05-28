using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DirectorButton : MonoBehaviour
{


    public void OnClickMakeRoom()
    {
        Debug.Log("방 만들기");
        SceneManager.LoadScene("MakeRoomScene");
    }

    public void OnClickSearchRoom()
    {
        Debug.Log("방 찾기");
        SceneManager.LoadScene("SearchRoomScene");
    }

    public void OnClickTmi()
    {
        Debug.Log("Tmi");
        SceneManager.LoadScene("TmiScene");
    }

    public void OnClickEndgame()
    {
        Debug.Log("END");
    }
}
