using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMasterScript : MonoBehaviour
{

	public int balance;

	public void setBalance(int value)
	{
		balance += value;
	}

	public int getBalance()
	{
		return balance;
	}
	
	public static int[] tiles = new int[40];
	

	public static int[] properties = new int[28];
	/*
	world1_1;
	world1_4;
	world2_1;
	world2_2;
	world2_4;
	world3_1;
	world3_3;
	world3_4;
	world4_1;
	world4_3;
	world4_4;
	world5_1;
	world5_3;
	world5_4;
	world6_1;
	world6_2;
	world6_4;
	world7_1;
	world7_2;
	world7_4;
	world8_1;
	world8_4;
	fireFlowerU1;
	superStarU2;
	lift;
	liftCloud;
	trampoline;
	vine;
	*/

	public static void purchase(int property)
	{
		properties[property] = 1;
	}

	
}
