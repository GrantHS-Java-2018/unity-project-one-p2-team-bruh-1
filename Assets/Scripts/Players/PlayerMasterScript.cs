using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMasterScript : MonoBehaviour
{

	public int balance
	{
		get { return balance; }
		set
		{
			if (value < 0)
			{
				balance = 0;
			}
			else
			{
				balance = 0;
			}
		}
	}

	public bool world1_1;
	public bool world1_4;
	public bool world2_1;
	public bool world2_2;
	public bool world2_4;
	public bool world3_1;
	public bool world3_3;
	public bool world3_4;
	public bool world4_1;
	public bool world4_3;
	public bool world4_4;
	public bool world5_1;
	public bool world5_3;
	public bool world5_4;
	public bool world6_1;
	public bool world6_2;
	public bool world6_4;
	public bool world7_1;
	public bool world7_2;
	public bool world7_4;
	public bool world8_1;
	public bool world8_4;
	public bool fireFlowerU1;
	public bool superStarU2;
	public bool lift;
	public bool liftCloud;
	public bool trampoline;
	public bool vine;

	public static void purchase(bool property)
	{
		property = true;
	}

	
	
}
