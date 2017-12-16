using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuestSystem{
public class CollectionObjective : IQuestObjective  {
		private string title;
		private string description;
		private int collectionAmount;
		private bool isComplete;
		private string verb;
		private int currentAmount;// 0
		private GameObject ItemToCollect;

		public CollectionObjective(string titleVerb, int totalAmount, GameObject item, string descrip){
			title= titleVerb + " " + totalAmount + " " + item.name;
			verb = titleVerb;
			description = descrip;
			ItemToCollect = item;
			collectionAmount = totalAmount;
			currentAmount = 0;
			CheckProgress ();
		}
		public string Description
		{
			get
			{
				return description;
			}
		}
		public string Title
		{
			get 
			{
				return title;
			}
		}
		public int CollectionAmount
		{
			get
			{
				return collectionAmount;
			}
		}
		public int CurrentAmount
		{
			get
			{
				return currentAmount;
			}
		}
		public GameObject itemToCollect
		{
			get
			{
				return ItemToCollect;
			}
		}
		public bool IsComplete
		{
			get{
				return isComplete;
			}
		}
		public void CheckProgress()
		{
			if (currentAmount >= collectionAmount)
				isComplete = true;
			else
				isComplete = false;
		}
		public void UpdateProgress()
		{
			//throw new NotImplementedException ();
		}
		public override string ToString()
		{
			return currentAmount + "/" + collectionAmount + " " + itemToCollect.name + " " + verb + "ed!";
		}

}
}
