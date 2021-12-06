using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Mins : MonoBehaviour
{

	public Text MinsText;
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		DateTime time = DateTime.Now;
		string mins = LeadingZero(time.Minute);
		MinsText.text = mins;
	}
	string LeadingZero(int n)
	{
		return n.ToString().PadLeft(2, '0');
	}
}
