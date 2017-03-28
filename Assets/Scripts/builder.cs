using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class builder : MonoBehaviour {

	public int counter = 0;
	public static int tileCount = 0;
	public Transform floorTileOne;
	public Transform floorTileTwo;
	public Transform builderPrefab;

	public Vector3 cameraPlace;
	public List<Vector3> tiles = new List<Vector3>(); 

	private float randomFloat;
	public static bool Done = false;
	private float selection;

	// Update is called once per frame
	void Update () {
		if (counter < 200 && tileCount <= 600) {

			//random number to check each time a tile is spawned/pathmaker moves
			randomFloat = Random.Range (0.0f, 1.0f);
			selection = Random.Range (0.0f, 1.0f);

			if (randomFloat < .20f) 
			{
				transform.Rotate (0f, 90f, 0f);
			}  
			else if (randomFloat >= .20f && randomFloat <= .40f) 
			{
				transform.Rotate (0f, -90f, 0f);
			}  
			else if (randomFloat >= .97f) 
			{
				Instantiate (builderPrefab, transform.position, Quaternion.identity);
			}

			if (tileCount <= 600) {

				if (selection >= .5f){
					Instantiate (floorTileOne, transform.position, Quaternion.identity);
					tiles.Add (transform.position);
					tileCount++;
				}
				else{
					Instantiate (floorTileTwo, transform.position, Quaternion.identity);
					tiles.Add (transform.position);
					tileCount++;
				}
			}  

			foreach(Vector3 i in tiles){
				cameraPlace += i;
			}
			cameraPlace = cameraPlace / tiles.Count;
			cameraPlace.y += Mathf.Abs(cameraPlace.z);

			transform.Translate (0f, 0f, 5f);

			counter++;

		}  

		else {
			Done = true;
		}
	}
}
