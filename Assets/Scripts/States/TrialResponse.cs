using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace CausalInfMSI
{
	public class TrialResponse : State
	{
		public TrialResponse(TaskManager taskManager) : base(taskManager)
		{

		}

        public override IEnumerator Start()
        {
            yield return new WaitForSeconds(1f);
            TaskManager.responseController.SpawnResponseBlobs();
            //yield return TaskManager.StartCoroutine(ListenForResponses());
            TaskManager.response = TaskManager.laserInput.response;
            TaskManager.LogData();

            // Go to next state
            TaskManager.SetState(new SecondTrialResponse(TaskManager));

        }

        //public IEnumerator ListenForResponses()
        //{

        //    TaskManager.responseController.enabled = true;
        //    while (TaskManager.responseController.enabled)
        //    {
        //        yield return null;
        //    }

        //    TaskManager.LogData();
        //}
    } 
}
