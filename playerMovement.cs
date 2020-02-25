using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{	
	public Vector3 heathen;
	
	public Transform moveThis;
	public LayerMask hitLayers;
	public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        heathen.Set(0, 2, 0);
    }
	
    
	
	
	// Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0)){
			Vector3 mouse = Input.mousePosition;
			Ray castPoint = Camera.main.ScreenPointToRay(mouse);
			RaycastHit hit;
			
			if (Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
			{
				heathen=hit.point;
			}
		}
	}
		
}
