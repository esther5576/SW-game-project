using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CompteurDeCubes : MonoBehaviour
{

	public int _compteurDeCubes;
	public List<GameObject> _ListOfCubes = new List<GameObject> ();

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (_ListOfCubes.Count > 3000) {
			Destroy (_ListOfCubes [0]);
			_ListOfCubes.RemoveAt (0);
			_compteurDeCubes--;
		}
	}

	void OnGUI ()
	{
		GUI.color = Color.black;
		GUI.Label (new Rect (500, 10, 100, 20), "Cubes: " + _compteurDeCubes);
	}
}
