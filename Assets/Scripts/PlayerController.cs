using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Rigidbody2D rigid;

    [Header("Specs")]
    [SerializeField] float jumpSpeed;

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
}
