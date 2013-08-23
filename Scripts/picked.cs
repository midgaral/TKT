using UnityEngine;
using System.Collections;

public class picked : MonoBehaviour {
	public bool ispicked;
	Vector3 screenpoint;
	Vector3 offset;

	// Use this for initialization
	void Start () {
	ispicked=false;
	}
	
	// Update is called once per frame
	void Update () {
	if(ispicked)
		{
			
			
		
			
		}
	}
	/*void OnMouseDown()
	{
		
	screenpoint =	Camera.main.WorldToScreenPoint(gameObject.transform.position);
 offset = screenpoint - Camera.main.ScreenToWorldPoint(
new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z)); 
		
	}
	
	void OnMouseDrag()
	{
	
		 Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		if(ispicked)
		{
			Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
transform.position = curPosition;
					
		}
			
		
		
	}
	*/
}
