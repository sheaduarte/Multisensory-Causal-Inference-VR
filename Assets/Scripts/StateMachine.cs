using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

namespace CausalInfMSI
{
	public abstract class StateMachine : MonoBehaviour 
	{
		protected State State;

		public void SetState(State state)
		{
			Debug.Log(state);

			State = state;
			StartCoroutine(State.Start());
		}
	} 
}

//keeps track of the current state