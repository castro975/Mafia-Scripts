using UnityEngine;
using System.Collections;

public class Role{
	#region Information
	public string roleName; 			//The name of the role. Most likely the name of the class as well (Doctor, Sheriff, Godfather, etc.)
	
	public enum Alliance{
		Town,
		Mafia,
		None
	}			 //An enum (List-like data structure) containing all of the teams in the game
	public Alliance alliedTeam;			//The actual team our character is associated with. 
										//The above enum lists the possible teams, but it doesn't give our character one to use
	#endregion
	
	#region Attributes
	public bool canAttackAtNight;		//Can our character attack a character at night or not (True or false)
	public bool canHeal;				//Can our character heal a character at night or not (True or false)
	public bool isInvulnerableAtNight;	//Is our character able to be attacked at night or not (True or false)
	#endregion
}