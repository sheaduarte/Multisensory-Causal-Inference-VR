using CausalInfMSI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace CausalInfMSI
{
	public class EndTrial : State
	{
		public EndTrial(TaskManager taskManager) : base(taskManager)
		{

		}

		public override IEnumerator Start()
		{
			yield return new WaitForSeconds(.5f);

			TaskManager.trial += 1;

			if (TaskManager.trial < TaskManager.numTrials)
			{
				TaskManager.SetState(new ITI(TaskManager));
			}
			else
			{
				TaskManager.SetState(new EndBlock(TaskManager));
			}

			yield return null;
		}
	} 
}
