using System.Collections;
using UnityEngine;

namespace CausalInfMSI
{
	public class EndBlock : State
	{
		public EndBlock(TaskManager taskManager) :base(taskManager)
		{

		}

		public override IEnumerator Start()
		{
			TaskManager.block += 1;

			if(TaskManager.block <TaskManager.numBlocks)
			{
				TaskManager.SetState(new StartBlock(TaskManager));
			}
			else
			{
				TaskManager.SetState(new EndTask(TaskManager));
			}

			yield return null;
		}
	} 
}
