using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionTest : MonoBehaviour 
{

	int playerHealth = 50;
	// Use this for initialization
	void Start () 
	{
		playerHealth = PlayerDamage(playerHealth);
		Debug.Log (playerHealth);
	}

	int PlayerDamage(int number)
	{
		int ret;
		ret = playerHealth - 5;
		return ret;
	}
}
