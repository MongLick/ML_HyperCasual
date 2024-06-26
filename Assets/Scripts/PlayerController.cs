using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Rigidbody2D rigid;
    [SerializeField] Animator animator;

    [Header("Specs")]
    [SerializeField] float jumpSpeed;
    [SerializeField] float moveSpeed;

    [Header("Events")]
    [SerializeField] UnityEvent OnDied;

	private void Update()
	{
        Rotate();
	}

    private void Rotate()
    {
        transform.right = rigid.velocity + Vector2.right * moveSpeed;
    }

	private void OnJump(InputValue value)
    {
        if(value.isPressed)
        {
            Jump();
        }
    }

    private void Jump()
    {
        // ���� ���� �ӵ� ���� : ���ӹ�� - ���� �ӵ� ��ȭ
        // rigid.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);

        // �ӵ��� ���� ���� : �ӵ�������� - ������ �ӵ��� ����
        rigid.velocity = Vector2.up * jumpSpeed;
    }

    private void Die()
    {
        animator.SetBool("Die", true);
		OnDied?.Invoke();
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        Die();
	}
}
