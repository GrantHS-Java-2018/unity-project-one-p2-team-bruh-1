﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

	private static GameObject whoWinsText, player1MoveText, Player2MoveText;

	[SerializeField] private GameObject player1, player2;

	public int diceSideThrown = 0;

	public int player1StartWaypoint = 0;
	public int player2StartWaypoint = 0;

	public bool gameOver = false;
	
	// Use this for initialization
	void Start ()
	{

		whoWinsText = GameObject.Find("WhoWinsText");
		player1MoveText = GameObject.Find("Player1MoveText");
		Player2MoveText = GameObject.Find("Player2MoveText");	

		player1.GetComponent<FollowingPath>().moveAllowed = false;
		player2.GetComponent<FollowingPath>().moveAllowed = false;
		
		whoWinsText.gameObject.SetActive(false);
		player1MoveText.gameObject.SetActive(true);
		
	}
	
	// Update is called once per frame
	void Update()
	{
		if (player1.GetComponent<FollowingPath>().waypointIndex > player1StartWaypoint + diceSideThrown)
		{
			player1.GetComponent<FollowingPath>().moveAllowed = false;
			player1MoveText.gameObject.SetActive(false);
			Player2MoveText.gameObject.SetActive(true);
			player1StartWaypoint = player1.GetComponent<FollowingPath>().waypointIndex - 1;
		}

		if (player2.GetComponent<FollowingPath>().waypointIndex > player2StartWaypoint + diceSideThrown)
		{
			player2.GetComponent<FollowingPath>().moveAllowed = false;
			Player2MoveText.gameObject.SetActive(false);
			player1MoveText.gameObject.SetActive(true);
			player2StartWaypoint = player2.GetComponent<FollowingPath>().waypointIndex - 1;
		}

		
		
		//change this to loss condition of bankruptcy.
		if (player1.GetComponent<P1Script>().GetComponent<int>(balance) = 0)
		{
			whoWinsText.gameObject.SetActive(true);
			player1MoveText.gameObject.SetActive(false);
			Player2MoveText.gameObject.SetActive(false);
			whoWinsText.GetComponent<Text>().text = "Player 1 wins!";
			gameOver = true;
		}

		if (player2.GetComponent<FollowingPath>().waypointIndex ==
		    player2.GetComponent<FollowingPath>().waypoints.Length)
		{
			whoWinsText.gameObject.SetActive(true);
			player1MoveText.gameObject.SetActive(false);
			Player2MoveText.gameObject.SetActive(false);
			whoWinsText.GetComponent<Text>().text = "Player 2 wins!";
			gameOver = true;
		}
	}
		public void MovePlayer(int playerToMove)
		{
			switch (playerToMove)
			{
				case 1:
					player1.GetComponent<FollowingPath>().moveAllowed = true;
					break;

				case 2:
					player2.GetComponent<FollowingPath>().moveAllowed = true;
					break;
			}
		}
}
