using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiki : MonoBehaviour
{
    public int nextMoveX;  // ���� ������ ��, ��
    public int nextMoveY;  // ���� ������ ��, ��

    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator animator;
    public MoleManager mm;
    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();


        Invoke("Movement", 1);   // ���� ������ 1�� �� �缳�� �Լ� ȣ��
        Invoke("OnOut", 2);  // 2�� �� ���� ������� �Լ� ȣ��
    }

    void Update()
    {
        if (nextMoveX >= 0)  // ���� ������ ���⿡ ���� �ִϸ��̼� ���� ����
            spriteRenderer.flipX = true;

        else
            spriteRenderer.flipX = false;


        if (rigid.velocity.normalized.x == 0)  // ���� �����ӿ� ���� �ִϸ��̼� ����
            animator.SetBool("isMoving", false);
        else
            animator.SetBool("isMoving", true);

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rigid.velocity = new Vector2(nextMoveX, nextMoveY);  // ���� ���� ������
    }

    void Movement()
    {
        nextMoveX = Random.Range(-1, 2);  // ���� ������ ��, �� ���� ȣ��
        nextMoveY = Random.Range(-1, 2);  // ���� ������ ��, �� ���� ȣ��
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

    public void DeActive()  // ���� ���� �Լ�
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
