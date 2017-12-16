using System.Collections.Generic;
namespace QuestSystem
{
	public class Quest
	{
		//Name
		//DescriptionSummary
		//Quest Hint
		//Quest Dialog
		//sourceID
		//questID
		public Quest(){
			
		}

		//Objectives
		private List<IQuestObjective> objectives;
		//Collection
		//10 Feathers
		//Killing 4 enemies
		//
		//Bonus objectives
		//rewards
		//events
			//on completerion
			//on failed
			//on update
		private bool IsComplete()
		{
			for (int i = 0; i < objectives.Count; i++) {
				if (!objectives[i].IsComplete) {
					return false;
				}
			}
			return true;
		}
	}
}