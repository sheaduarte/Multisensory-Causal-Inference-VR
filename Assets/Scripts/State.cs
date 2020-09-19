using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CausalInfMSI
{
	public abstract class State
	{
		protected TaskManager TaskManager;

		public State(TaskManager taskManager)
		{
			TaskManager = taskManager;
		}

		public virtual IEnumerator Start()
		{
			yield break;
		}
	} 
}

