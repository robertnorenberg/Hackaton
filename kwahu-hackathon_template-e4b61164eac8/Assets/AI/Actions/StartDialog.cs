using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Core;
using RAIN.Action;

[RAINAction]
public class StartDialog : RAINAction
{
	public bool playing = false;
	public AI globalAI;
	public StartDialog()
	{
		actionName = "StartDialog";
	}
	
	public override void Start(AI ai)
	{
		globalAI = ai;
		int number = ai.WorkingMemory.GetItem<int>("dialogNumber");

		if (playing == false) {
			Dialoguer.StartDialogue (number);
			Dialoguer.events.onEnded += HandleonEnded;
			playing = true;
				}

	//	ai.WorkingMemory.SetItem<bool>("dialogMode", true);
		base.Start(ai);
	}

	void HandleonEnded ()
	{
		Dialoguer.events.onEnded -= HandleonEnded;
		globalAI.WorkingMemory.SetItem<bool>("dialogDone", true);
		globalAI.WorkingMemory.SetItem<bool>("dialogMode", false);
	//	globalAI.WorkingMemory.SetItem<ga>("varPlayer", null);
	//	globalAI.WorkingMemory.SetItem<bool>("varRange", null);
		playing = false;
	}
	
	public override ActionResult Execute(AI ai)
	{
		Debug.Log ("execute");
	//	Dialoguer.
		//return ActionResult.SUCCESS;
		return ActionResult.FAILURE;
	}
	
	public override void Stop(AI ai)
	{
		Debug.Log ("stop");
		base.Stop(ai);
	}
}