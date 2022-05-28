// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Diagnostics;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.SceneManagement;

// public class GameManager : MonoBehaviour// ���� ���� ���¸� ǥ��, ���� ������ UI �����ϴ� ���� �Ŵ���
// {
//     public static GameManager instance; // �̱��� �Ҵ��� ��������
//     public bool isGameover = false;    // ���ӿ��� ����
//     public Text Touch_Number_Text;    // ������ ����� UI �ؽ�Ʈ
//     public GameObject gameoverUI;       // ���� ���� �� ����� UI ���� ������Ʈ
//     private int score = 0;              // ���� ����
//     Random rand = new Random();
//     int defnum = rand.Next(20, 60);
//     int touch_number = 0;
//     float running_time = 0;   

//      public void Add_score()      // ������ ������Ű�� �޼���
//     {
//         score += 1;
//     }

//     void Awake() 
//     {
//         if (instance == null)
//         {
//             instance = this;
//         }    

//         else
//         {
//             Debug.Debug.LogWarning("���� �� �� �̻��� ���� �Ŵ����� �����մϴ�.");
//             Destroy(gameObject);
//         }
//     }

//     // Start is called before the first frame update
//     void Start()
//     {
//         Touch_Number_Text.text = defnum + "�� ��������";    // ���� ���۽� �� �� �������� �����ش�.
//         // TG gamer1 = new TG();
//         // Stopwatch t = new Stopwatch();
//         // t.Start();
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         if (Input.GetMouseButtonDown(0))
//         {
//             Add_score();            // ��ġ �Է��� ���� ��� ���� ����
            
//             if (score > defnum)     // �Է¹��� ��ġ���� ��ǥ ��ġ������ Ŭ ��� ������ 0�� ó���ǰ� ������ ����ȴ�.
//             {
//                 score = 0;
//                 isGameover = true;

//                 gameoverUI.SetActive(true);
//             }
//         }
//     }
// }

// using System;
// using System.Collections;
// using System.Collections.Generic;
// using System.Diagnostics;
// using UnityEngine;
// using UnityEngine.UI;
// using UnityEngine.SceneManagement;

// public class GameManager : MonoBehaviour// ???? ???? ???��? ???, ???? ?????? UI ??????? ???? ?????
// {
//     public static GameManager instance; // ????? ????? ????????
//     public bool isGameover = false;    // ??????? ????
//     public Text Touch_Number_Text;    // ?????? ????? UI ????
//     public GameObject gameoverUI;       // ???? ???? ?? ????? UI ???? ???????
//     private int score = 0;              // ???? ????
//     Random rand = new Random();
//     int defnum = rand.Next(20, 60);
//     int touch_number = 0;
//     float running_time = 0;
//     float Timer;
//     int overtime = 0; // overtime?? 1??? ???? ????

//     public void Add_score()      // ?????? ????????? ?????
//     {
//         score += 1;
//     }

//     void Awake()
//     {
//         if (instance == null)
//         {
//             instance = this;
//         }

//         else
//         {
//             Debug.Debug.LogWarning("???? ?? ?? ????? ???? ??????? ????????.");
//             Destroy(gameObject);
//         }
//     }

//     // Start is called before the first frame update
//     void Start()
//     {

//         Touch_Number_Text.text = defnum + "?? ????????";    // ???? ????? ?? ?? ???????? ???????.

//     }

//     void OverTime()
//     {
//         Timer += Time.deltaTime;
//         if (Input.GetMouseButtonDown(0)) // 1?? ??????? ????? ????? ??? ?��??? 0???? ????
//         {
//             overtime = 1;
//         }

//         if (Timer > 1f)
//             overtime = 0;
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

//         if (Input.GetMouseButtonDown(0))
//         {
//             Add_score();            // ??? ????? ???? ??? ???? ????

//             if(score == 1) // ?????? 1?????
//             {
//                 watch.Start(); // ??? ?��? ????
//             }
//             if (score == defnum) // ???? ????? ??????
//             {
//                 OverTime(); // 1????? ?????? ????????? ????
//                 watch.Stop(); // ??? ?��?????
//                 if (overtime == 0)
//                     running_time = watch.ElapsedMilliseconds;
//                 else
//                     running_time = 9999;
//                 Debug.Log(running_time + " ms");
//                 isGameover = true;
//                 gameoverUI.SetActive(true);
//             }
//         }
//     }

// }
