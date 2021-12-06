using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Hour : MonoBehaviour {

	public Text HourText;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		DateTime time = DateTime.Now;
		string hour = LeadingZero(time.Hour);
		HourText.text = hour;
	}
	string LeadingZero(int n)
	{
		return n.ToString().PadLeft(2, '0');
	}
}
