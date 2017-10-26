using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(fileName = "Dependencies", menuName = "Dependencies", order = 4000)]
public class CreateDependency : ScriptableObject {

	[Header("Basic Project Info")]
	public string ProjectName;

	[Multiline]
	public string Description;

	public string[] Authors;

	[Space]

	[Header("Information On The Dependencies In This Project"), Multiline]
	public string[] Dependencies;

}
