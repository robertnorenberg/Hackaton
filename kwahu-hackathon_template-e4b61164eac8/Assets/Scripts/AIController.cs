using UnityEngine;
using System.Collections;
using RAIN.BehaviorTrees;
using RAIN.Minds;

//Arkadiusz Kwasny - 04.08.2014

public class AIController : MonoBehaviour
{
		private RAIN.Core.AIRig rig;
		private string currentTreeName = null;
		
		/*
		private bool _lookForPlayer = false;
		public bool LookForPlayer {
				get {
						return _lookForPlayer;
				}
				set {
						_lookForPlayer = value;
						if (rig == null)
								Debug.LogError ("AIRig component is missing in : " + name);
						rig.AI.WorkingMemory.SetItem<bool> ("lookForPlayer", _lookForPlayer);
				}
		}*/

		private void Awake ()
		{
				rig = GetComponent<RAIN.Core.AIRig> ();
				if (rig == null)
						Debug.LogError ("AIRig component is missing in : " + name);
		}

		// Use this for initialization
		public virtual void Start ()
	{


		}

		public bool RunTree (string name)
		{
				if (rig != null && currentTreeName != name) {
						BTAsset behavior = Resources.Load ("BehaviourTrees/" + name) as BTAsset;

						if (behavior == null)
								return false;
						currentTreeName = name;
						(rig.AI.Mind as BasicMind).behaviorTreeAsset = behavior;
						rig.AI.AIInit ();
						return true;
				} else
						return false;
		}

		public bool GetBool (string name)
		{
				return rig.AI.WorkingMemory.GetItem<bool> (name);
		}

		public void SetBool (string name, bool value)
		{
				rig.AI.WorkingMemory.SetItem<bool> (name, value);
		}

		public int GetInt (string name)
		{
				return rig.AI.WorkingMemory.GetItem<int> (name);
		}

		public void SetInt (string name, int value)
		{
				rig.AI.WorkingMemory.SetItem<int> (name, value);
		}

		public GameObject GetGameObject (string name)
		{
				return rig.AI.WorkingMemory.GetItem<GameObject> (name);
		}

		public void SetGameObject (string name, GameObject value)
		{
				rig.AI.WorkingMemory.SetItem<GameObject> (name, value);
		}
	
}