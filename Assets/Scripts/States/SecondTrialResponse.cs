using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace CausalInfMSI
{
    public class SecondTrialResponse : State
    {
        public SecondTrialResponse(TaskManager taskManager) : base(taskManager)
        {

        }

        public override IEnumerator Start()
        {            
            yield return new WaitForSeconds(2f);
            TaskManager.secondResponseController.SpawnSecondResponseBlobs();
            //yield return TaskManager.StartCoroutine(ListenForResponses());
            TaskManager.response = TaskManager.laserInput.response;
            TaskManager.LogData();

            // Go to next state
            TaskManager.SetState(new EndTrial(TaskManager));
        }

        //public IEnumerator ListenForResponses()
        //{

        //    TaskManager.laserInput.enabled = true;
        //    while (TaskManager.laserInput.enabled)
        //    {
        //        yield return null;
        //    }

        //    TaskManager.LogData();
        //}

    }
}