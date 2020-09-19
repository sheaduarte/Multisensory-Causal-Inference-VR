using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CausalInfMSI
{
	public class ITI : State
	{
		public ITI(TaskManager taskManager) : base(taskManager)
		{

		}

		public override IEnumerator Start()
		{
			yield return new WaitForSeconds(3f);
			TaskManager.SetState(new StartTrial(TaskManager));
		}
	} 
}
