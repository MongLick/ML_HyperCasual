using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeLineMover : MonoBehaviour
{
    [SerializeField] float moveSpeed;

	private void Start()
	{
		Destroy(gameObject, 5f);
	}

	private void Update()
	{
		transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
	}
}
