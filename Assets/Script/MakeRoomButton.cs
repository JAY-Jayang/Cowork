using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Makeroombutton : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //버튼 오브젝트 링크 함수
    public void OnClickMakeRoom()
    {
        Debug.Log("방 만들기");
        SceneManager.LoadScene("MakeRoomScene");
    }
}
