﻿using UnityEngine;
using System.Collections;

public class JournalController : MonoBehaviour {

	void Start () 
	{
		GameObject mdc_obj = GameObject.FindGameObjectWithTag("MasterData");
		MasterDataController mdc = null;
		if( mdc_obj != null )
		{
			mdc = mdc_obj.GetComponent<MasterDataController>();
		}

		if ( mdc != null )
			mdc.bJournalDone = true;
	}

	public void OnPress( int buttonID )
	{
		Application.LoadLevel("MainMenu");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
