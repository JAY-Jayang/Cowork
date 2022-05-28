using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoleManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] kuku;
    public GameObject[] kiki;
    public Text timeText;
    public Text scoreText;

    public float time;
    public int score;

    float Ku_respawn; // 재생성 시간
    float Ki_respawn;
    void Start()
    {
        Ku_respawn = 1.5f;
        Ki_respawn = 2;
        score = 0;
        StartCoroutine("KuSpawnUnit");
        StartCoroutine("KiSpawnUnit");
        StartCoroutine("TimeAttack");
    }

    IEnumerator KuSpawnUnit()
    {
        while (true)
        {
            yield return new WaitForSeconds(Ku_respawn);
            float KupositionX = Random.Range(-1, 1);
            float KupositionY = Random.Range(-1, 1);
            int m = Random.Range(0, kuku.Length);
            if (!kuku[m].activeSelf)
            {
                kuku[m].SetActive(true);
                kuku[m] = (GameObject)Instantiate(kuku[m], new Vector2(KupositionX, KupositionY), Quaternion.identity);
            }
        }
    }

    IEnumerator KiSpawnUnit()
    {
        while (true)
        {
            yield return new WaitForSeconds(Ki_respawn);
            float KipositionX = Random.Range(-1, 1);
            float KipositionY = Random.Range(-1, 1);
            int n = Random.Range(0, kiki.Length);
            if (!kiki[n].activeSelf)
            {
                kiki[n].SetActive(true);
                kiki[n] = (GameObject)Instantiate(kiki[n], new Vector2(KipositionX, KipositionY), Quaternion.identity);
            }
        }
    }

    IEnumerator TimeAttack()
    {
        time = 10;
        while (true)
        {
            time -= Time.deltaTime;
            timeText.text = string.Format("{0:0}", time);
            yield return null;

            if (time <= 0)
            {
                StopAllCoroutines();

            }
        }
    }
}
