using UnityEngine;
using System.Collections;

public class Mouse : MonoBehaviour {


    public GameObject particle;
	GameObject clone;
	Vector3 point;
	// Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
     RaycastHit hit;
    void Update() {
        if (Input.GetButtonDown("Fire1")) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray,out hit))
			{
				if(hit.collider.gameObject.name=="Terrain")
				{
                clone =(GameObject)Instantiate(particle, transform.position, transform.rotation);
					Vector3 offset = new Vector3(0,-10,0);
				clone.transform.position = hit.point+offset;
				clone.name = "sphere";
					clone.tag="obj";
				}
				
				if(hit.collider.gameObject.tag == "obj")
				{
					hit.collider.gameObject.GetComponent<picked>().ispicked=true;
					
				Debug.Log(hit.collider.gameObject.name.ToString());	
				}
			}
}
	}
	
}