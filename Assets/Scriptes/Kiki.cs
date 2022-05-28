using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiki : MonoBehaviour
{
    public int nextMoveX;  // 다음 움직임 좌, 우
    public int nextMoveY;  // 다음 움직임 상, 하

    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator animator;
    public MoleManager mm;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();


        Invoke("Movement", 1);   // 다음 움직임 1초 후 재설정 함수 호출
        Invoke("OnOut", 2);  // 2초 후 유닛 사라지는 함수 호출
    }

    void Update()
    {
        if (nextMoveX >= 0)  // 유닛 움직임 방향에 맞춰 애니메이션 방향 설정
            spriteRenderer.flipX = true;

        else
            spriteRenderer.flipX = false;


        if (rigid.velocity.normalized.x == 0)  // 유닛 움직임에 맞춰 애니메이션 설정
            animator.SetBool("isMoving", false);
        else
            animator.SetBool("isMoving", true);

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(nextMoveX, nextMoveY);  // 유닛 랜덤 움직임
    }

    void Movement()
    {
        nextMoveX = Random.Range(-1, 2);  // 다음 움직임 좌, 우 랜덤 호출
        nextMoveY = Random.Range(-1, 2);  // 다음 움직임 상, 하 랜덤 호출
        Invoke("Movement", 1);
    }

    public void OnDie()
    {
        animator.SetTrigger("doDie");
        Invoke("DeActive", 0.15f);
    }

    public void OnOut()
    {
        animator.SetTrigger("doOut");
        Invoke("DeActive", 0.7f);
    }

    public void DeActive()  // 유닛 제거 함수
    {
        gameObject.SetActive(false);
    }

    public void OnMouseDown()
    {
        OnDie();
        mm.score -= 10;
        if (mm.score < 0)
            mm.score = 0;
        mm.scoreText.text = mm.score.ToString();
    }

}
