using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

namespace CausalInfMSI
{
	public class EndTask : State
	{
		public EndTask(TaskManager taskManager) : base(taskManager)
		{

		}

		public override IEnumerator Start()
		{
			yield return null;
			Util.QuitRequest();
		}
	} 
}
