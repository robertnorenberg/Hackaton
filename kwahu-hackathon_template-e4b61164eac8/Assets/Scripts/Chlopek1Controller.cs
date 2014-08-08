using UnityEngine;
using System.Collections;

//Arkadiusz Kwasny - 04.08.2014

public class Chlopek1Controller : AIController
{
		bool talked = false;
		bool inDialogMode = false;
		public GameObject route;

		public override void Start ()
		{
				base.Start ();
				RunTree ("patrol until found player");
				SetGameObject ("route", route);
		}

		void Update ()
		{
				//approach player if spoted
				if (GetGameObject ("varPlayer") != null)
						RunTree ("approach player");

				//talk to player if in conversation range
				if (GetGameObject ("varPlayerClose") != null && !inDialogMode && !talked) {
						inDialogMode = true;
						Dialoguer.StartDialogue (4);
						Dialoguer.events.onEnded += FinishDialog;
				}
				//continue to patrol once the conversation is finished
				if (talked)
						RunTree ("patrol");
		}

		void FinishDialog ()
		{
				Dialoguer.events.onEnded -= FinishDialog;
				inDialogMode = false;
				talked = true;
		}
}