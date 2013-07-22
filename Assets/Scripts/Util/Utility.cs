using UnityEngine;
using System.Collections;


/*
 *		Author: 	Craig Lomax
 *		Date: 		31.08.2011
 *		URL:		clomax.me.uk
 *		email:		craig@clomax.me.uk
 *
 */

 

public class Utility : MonoBehaviour {

	 // generate random float in the vicinity of n
	 public static float RandomApprox(float n, float r) {
		return Random.Range(n-r, n+r);
	}
	
	//return a random 'flat' vector within a given range
	public static Vector3 RandomFlatVec(float x, float y, float z) {
		Vector3 vec = new Vector3( Random.Range(-x,x),
								   y / 2,
								   Random.Range(-z,z)
			                     );
		return vec;
	}
	
	//return a random rotation on the y axis
	public static Vector3 RandomRotVec() {
		return new Vector3(0,Random.Range(0,360),0);
	}
	
	public static T rangeConvert<T> (float min, float max, float old_val) {
		int oldRange = 255;
		float newRange = (max - min);
		return (T) System.Convert.ChangeType( (((old_val - 0) * newRange) / oldRange) + min, typeof(T) );
	}
}
