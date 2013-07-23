using UnityEngine;
using System.Collections;

public struct Role{
	public string roleName;
	public enum Alliance{
		Town,
		Mafia,
		None
	}
	public Alliance alliedTeam;
}

