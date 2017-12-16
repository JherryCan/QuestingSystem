using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuestSystem{
public class QuestIdentifier :IQuestIdentifier {
		private int id;
		private int sourceID;

		public int SourceID 
		{
			get {
				return sourceID;
			}
		}
		public int ID
		{
				get{
				return id;	
				}
		}
	}
}
