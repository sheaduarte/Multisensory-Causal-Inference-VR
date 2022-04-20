﻿using System.Collections;
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
<<<<<<< HEAD
		List<string> variableList = new List<string>() { "subject", "trial", "stimulus","first_response", "second_response" }; // removed ,"second_response" 
=======
		List<string> variableList = new List<string>() { "subject", "trial", "response" };
>>>>>>> parent of f9ce7df (Changes to response system)
		private string dataPath;
		public string subjectID;
		public string response;
		public string stim;
		public int numBlocks = 1;
		public int block = 0;
		public int trial = 0;
		
		public GameObject[] stimObjects;
		public int numTrials = 50;

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
			string stim = spawnController.getStimulus();

			_dataController.row["subject"] = subjectID;
			_dataController.row["trial"] = trial.ToString();
			_dataController.row["stimulus"] = stim;
			_dataController.row["response"] = response;

			_dataController.Log();
		}

		public void setStimulus()
        {
			//gameObject.GetComponent("SpawnController").setStimObjects(stimObjects);
			spawnController.setStimObjects(stimObjects);
		}
	} 
}
