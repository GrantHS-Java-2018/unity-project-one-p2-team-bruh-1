using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyMasterScript : MonoBehaviour
{

	public int price;
	public int hotels;

	public virtual void MakeSound()
	{
		Debug.Log("No sound detected");
	}

	private void Start()
	{
		MakeSound();
	}
}
