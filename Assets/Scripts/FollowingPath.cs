using System.Collections;
using System.Collections.Generic;
using Boo.Lang.Environments;
using UnityEngine;

public class FollowingPath : MonoBehaviour
{
	
	public Transform[] waypoints;

	[SerializeField] private float moveSpeed = 1f;

	[HideInInspector] public int waypointIndex = 0;

	public GameObject player1, player2;
	
	public bool moveAllowed = false;

	public GameObject activePlayer;
	
	// Use this for initialization
	void Start ()
	{
		transform.position = waypoints[waypointIndex].transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (moveAllowed)
			Move();
		
	}
	
	
	
	
	
	private void Move()
	{	
		if (waypointIndex <= waypoints.Length - 1)
		{
			player1.GetComponent<FollowingPath>().waypointIndex %= 40;
			player2.GetComponent<FollowingPath>().waypointIndex %= 40;

			transform.position = Vector2.MoveTowards(transform.position,
				waypoints[waypointIndex].transform.position,
				moveSpeed * Time.deltaTime);

			if (transform.position == waypoints[waypointIndex].transform.position)
			{
				waypointIndex += 1;
			}
		}
	}
}

