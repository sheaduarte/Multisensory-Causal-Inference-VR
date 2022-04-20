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
<<<<<<< HEAD
            yield return new WaitForSeconds(1f); // delay
            TaskManager.responseController.SpawnResponseBlobs(); // spawn response blobs
            Debug.Log("before");
            TaskManager.firstResponse = TaskManager.laserInput.response;
            yield return new WaitUntil(() => TaskManager.laserInput.gotResponse); // wait until there's a response
            Debug.Log(TaskManager.laserInput.gotResponse); // log that a response was made
            Debug.Log("after");
            TaskManager.firstResponse = TaskManager.laserInput.response; // set first response in task manager/laser input
            yield return new WaitForSeconds(0.5f); // pause
            TaskManager.responseController.DestroyAllObjects(); //destroy the response blobs
            TaskManager.laserInput.gotResponse = false; // turn the response back to false

            // Second Response
            TaskManager.responseController.SpawnResponseBlobs();
            Debug.Log("before");
            yield return new WaitUntil(() => TaskManager.laserInput.gotResponse);
            Debug.Log(TaskManager.laserInput.gotResponse);
            Debug.Log("after");
            TaskManager.secondResponse = TaskManager.laserInput.response;
=======
            yield return new WaitForSeconds(1f);
            TaskManager.responseController.SpawnResponseBlobs();
            //yield return TaskManager.StartCoroutine(ListenForResponses());
            TaskManager.response = TaskManager.laserInput.response;
>>>>>>> parent of f9ce7df (Changes to response system)
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
