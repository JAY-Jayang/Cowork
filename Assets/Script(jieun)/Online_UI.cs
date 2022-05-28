// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class Online_UI : MonoBehaviour
// {
//     [SerializeField]
//     private InputField nicknameInputField;
//     [SerializeField]
//     private GameObject MakeRoomUI;

//     public void OnClickMakeRoom()
//     {
//         if(nicknameInputField.text != "")
//         {
//             PlayerSetting.nickname = nicknameInputField.text;
//             MakeRoomUI.SetActive(true);
//             gameObject.SetActive(false);
//         }
//         else
//         {
//             nicknameInputField.GetComponent<Animator>().SetTrigger("on");
//         }
//     }
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
