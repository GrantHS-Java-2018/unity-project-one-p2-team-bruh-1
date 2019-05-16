using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
	private static GameObject whoWinsText, player1MoveText, Player2MoveText;

	public GameObject player1, player2;

	public int diceSideThrown = 0;

	public int player1StartWaypoint = 0;
	public int player2StartWaypoint = 0;

	public bool gameOver = false;
	
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
	
	void Update()
	{	
        //checks if player one is going to do a loop
        if (player1StartWaypoint + diceSideThrown > 39 )
        {
            // if player 1 is going to do a loop make the game think that its just starting again but from a negative pos
            player1StartWaypoint = player1StartWaypoint - 39;
        }
        //checks if player two is going to do a loop
        if (player2StartWaypoint + diceSideThrown > 39)
        {
            // if player 2 is going to do a loop make the game think that its just starting again but from a negative pos
            player2StartWaypoint = player2StartWaypoint - 39;
        }
        if (player1.GetComponent<FollowingPath>().waypointIndex == player1StartWaypoint + diceSideThrown)
        {
            player1.GetComponent<FollowingPath>().moveAllowed = false;
            player1MoveText.gameObject.SetActive(false);
            Player2MoveText.gameObject.SetActive(true);
            player1StartWaypoint = player1.GetComponent<FollowingPath>().waypointIndex;
        }
        if (player2.GetComponent<FollowingPath>().waypointIndex == player2StartWaypoint + diceSideThrown)
        {
            player2.GetComponent<FollowingPath>().moveAllowed = false;
            Player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            player2StartWaypoint = player2.GetComponent<FollowingPath>().waypointIndex;
        }
          

        if (player1.GetComponent<FollowingPath>().waypointIndex > player1.GetComponent<FollowingPath>().waypoints.Length-1)
		{
			player1.GetComponent<FollowingPath>().waypointIndex %= 40;
		}
        if (player2.GetComponent<FollowingPath>().waypointIndex > player2.GetComponent<FollowingPath>().waypoints.Length-1)
		{
			player2.GetComponent<FollowingPath>().waypointIndex %= 40;
		}

		if (player1.GetComponent<PlayerMasterScript>().getBalance() <= 0)
		{
			whoWinsText.gameObject.SetActive(true);
			player1MoveText.gameObject.SetActive(false);
			Player2MoveText.gameObject.SetActive(false);
			whoWinsText.GetComponent<Text>().text = "Player 1 wins!";
			gameOver = true;
		}

		if (player2.GetComponent<PlayerMasterScript>().getBalance() <= 0)
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
