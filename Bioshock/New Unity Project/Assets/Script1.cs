using UnityEngine;
using System.Collections;

public class Firstscript : MonoBehaviour 
{
	public int myInt = 20;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	
	// Update is called once per frame
	void Update () 
	{
		myInt = MultiplyByTwo (myInt);
		Debug.Log (myInt);
	}
	int AddOne (int Number)
	{
		int ret;
		ret = Number + 2;
		return ret;
		
		
	}
}
