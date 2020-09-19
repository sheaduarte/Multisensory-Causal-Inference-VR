using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace CausalInfMSI
{
	[CreateAssetMenu(fileName = "TaskEventObject", menuName = "ScriptableObjects/TaskEvent")]
	public class TaskEvent : ScriptableObject
	{
		private UnityEvent unityEvent = new UnityEvent();

		public void Register(UnityAction call)
		{
			unityEvent.AddListener(call);
		}

		public void Deregister(UnityAction call)
		{
			unityEvent.RemoveListener(call);
		}

		public void Raise()
		{
			unityEvent.Invoke();
		}
	} 
}
