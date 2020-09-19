using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

namespace CausalInfMSI
{
	public class TaskManager : StateMachine
	{
		private State _priorState;

		// data variables
		List<string> variableList = new List<string>() { "subject", "trial", "response" };
		private string dataPath;
		public string subjectID;
		public string response;
		public string stim;
		public int numTrials = 10;
		public int numBlocks = 1;
		public int block = 0;
		public int trial = 0;

		public LaserInput laserInput;
		public SpawnController spawnController;
		public ResponseController responseController;
		public SecondResponseController secondResponseController;
		private DataController _dataController;

		private void Start()
		{
			// data writer
			dataPath = Path.Combine(Application.dataPath, "..", "..", "Data");
			_dataController = new DataController(variableList, dataPath, subjectID);
			_dataController.Activate();


			SetState(new StartBlock(this));
		}

		private void OnEnable()
		{
			//logDataRow.Register(LogData);
			//_dataController.Activate();
		}

		private void OnDisable()
		{
			//logDataRow.Deregister(LogData);
			_dataController.Deactivate();
		}

		public void LogData()
		{
			//string stim = spawnController.GetStimSpawned();
			//string response = responseController.response;
			string response = laserInput.response;

			_dataController.row["subject"] = subjectID;
			_dataController.row["trial"] = trial.ToString();
			_dataController.row["response"] = response;
			//_dataController.row["stimulus"] = stim;

			_dataController.Log();
		}
	} 
}
