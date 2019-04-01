using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{

	private static GameObject whoWinsText, player1MoveText, Player2MoveText;

	private static GameObject player1, player2;

	public static int diceSideThrown = 0;

	public static int player1StartWaypoint = 0;
	public static int player2StartWaypoint = 0;

	public static bool gameOver = false;
	
	// Use this for initialization
	void Start ()
	{

		whoWinsText = GameObject.Find("WhoWinsText");
		player1MoveText = GameObject.Find("Player1MoveText");
		Player2MoveText = GameObject.Find("Player2MoveText");
		
		player1 = GameObject.Find("player1");
		player2 = GameObject.Find("player2");

		player1.GetComponent<FollowingPath>().moveAllowed = false;
		player2.GetComponent<FollowingPath>().moveAllowed = false;
		
		whoWinsText.gameObject.SetActive(false);
		player1MoveText.gameObject.SetActive(true);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
