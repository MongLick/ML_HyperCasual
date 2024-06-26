using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GameSceneFlow : MonoBehaviour
{
	public UnityEvent OnReady;
	public UnityEvent OnPlay;
	public UnityEvent OnGameOver;

	private State state;

	public enum State
	{
		Ready,
		Play,
		GameOver
	}

	private void Start()
	{
		ChangeState(State.Ready);
	}

	public void ChangeState(State state)
	{
		this.state = state;
		switch (state)
		{
			case State.Ready:
				OnReady.Invoke();
				break;
			case State.Play:
				OnPlay.Invoke();
				break;
			case State.GameOver:
				OnGameOver.Invoke();
				break;
		}
	}

	private void OnGameStart(InputValue value)
	{
		if(state == State.Ready)
		{
			ChangeState(State.Play);
		}
	}

	public void GameOver()
	{
		if(state == State.Play)
		{
			ChangeState(State.GameOver);
		}
	}
}
