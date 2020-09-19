using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace CausalInfMSI
{
	public class StartTrial : State
	{
		public StartTrial(TaskManager taskManager): base(taskManager)
		{
			
		}

		public override IEnumerator Start()
		{
			TaskManager.spawnController.SpawnRandomStim();
			yield return null;
			TaskManager.SetState(new TrialResponse(TaskManager));
		}
	} 
}