using UnityEngine;
using System.Collections;

public class Ruedas : MonoBehaviour {

	// Use this for initialization
	public void crearllantas(){
		GameObject llanta1 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta1.transform.position = new Vector3 (10.02132f, 0.7198889f,-6.859875f);
		llanta1.transform.localScale = new Vector3 (1, 0.1005499f, 1);
		llanta1.transform.rotation = Quaternion.Euler (90, 0, 0);
		
		GameObject llanta2 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta2.transform.position = new Vector3 (10.02132f, 0.7198892f,-8.781905f);
		llanta2.transform.localScale = new Vector3 (1, 0.1005499f, 1);
		llanta2.transform.rotation = Quaternion.Euler (90, 0, 0);
		
		GameObject llanta3 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta3.transform.position = new Vector3 (7.223932f, 0.7784822f,-6.859876f);
		llanta3.transform.localScale = new Vector3 (1.13665f, 0.11429f, 1.13665f);
		llanta3.transform.rotation = Quaternion.Euler (90, 0, 0);
		
		GameObject llanta4 = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
		llanta4.transform.position = new Vector3 (7.223932f, 0.7784822f,-8.810316f);
		llanta4.transform.localScale = new Vector3 (1.13665f, 0.11429f, 1.13665f);
		llanta4.transform.rotation = Quaternion.Euler (90, 0, 0);
	}
}
