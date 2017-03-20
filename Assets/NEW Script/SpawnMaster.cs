using UnityEngine;
using System.Collections;

public class SpawnMaster : MonoBehaviour
{
	public GameObject Bird = null;
	private Component BirdPozitionScript;
	private ArrayList availablePozitions = new ArrayList ();
	private float birdSpawnRate = 2f;

	void Start ()
	{
		BirdPozitionScript = Bird.GetComponent<BirdPozition> ();
		StartCoroutine (randomSpawnBird ());
	}

	private IEnumerator randomSpawnBird ()
	{
		while (true) {
			yield return new WaitForSeconds (birdSpawnRate);
			if (availablePozitions.Count > 0) {      //da ne bo iskal če ni frei pozicij
				int ran;
				ran = Random.Range (0, availablePozitions.Count - 1);
				int poz = (int)availablePozitions [ran];
				//TODO
				availablePozitions.RemoveAt (ran);
			}
		}
	}

	public static void freePozition (int pozition)
	{
		availablePozitions.Add (pozition);
	}
}
