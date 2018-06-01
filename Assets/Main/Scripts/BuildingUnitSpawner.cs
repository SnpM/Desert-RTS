using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lockstep;
namespace DesertRTS {
	public class BuildingUnitSpawner : Ability {

		[FixedNumber]
		public long spawnInterval;

		[DataCode ("Agents")]
		public string spawnAgentCode;

		long spawnAcc;
		protected override void OnInitialize ()
		{
			
		}
		protected override void OnSimulate ()
		{
			spawnAcc += LockstepManager.DeltaTime;
			if (spawnAcc >= spawnInterval) {
				spawnAcc = 0;
				SpawnUnit ();
			}
		}
		void SpawnUnit () {
			Agent.Controller.CreateAgent (spawnAgentCode, Agent.Body.Position);
		}
	}
}