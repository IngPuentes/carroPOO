using UnityEngine;
using System.Collections;

public class Carro : MonoBehaviour {

	// Use this for initialization
	public void crearCarro(){
		Carroceria crr = new Carroceria ();
		Ruedas rue = new Ruedas ();
		Spoiler spo = new Spoiler ();

		crr.crearcarroceria ();
		rue.crearllantas ();
		spo.crearspoiler ();


	}

}
