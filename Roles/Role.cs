using UnityEngine;
using System.Collections;

public class Role{
	#region Information
	public string roleName;
	
	public enum Alliance{
		Town,
		Mafia,
		None
	}
	public Alliance alliedTeam;
	#endregion
	
	#region Attributes
	public bool canAttackAtNight;		//Can our character attack a character at night or not (True or false)
	public bool canHeal;				//Can our character heal a character at night or not (True or false)
	public bool isInvulnerableAtNight;	//Is our character able to be attacked at night or not (True or false)
	#endregion
}