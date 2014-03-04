using UnityEngine;
using System.Collections;

public class Spoiler : MonoBehaviour {

	// Use this for initialization
public void crearspoiler(){
		GameObject cube8 = GameObject.CreatePrimitive (PrimitiveType.Cube);
		cube8.transform.position = new Vector3(6.741031f, 2.110087F, -7.839122f);
		cube8.transform.localScale = new Vector3 (0.5036803f,0.1035894f,2.180262f);
		cube8.transform.rotation = Quaternion.Euler (0,0,27.33509f);
		}
}
