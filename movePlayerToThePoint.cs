using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayerToThePoint : MonoBehaviour
{
	GameObject go;
	Vector3 heathen;
	Transform moveThis;
	float speed;
	playerMovement PlayerMovement;
    // Start is called before the first frame update
    void Start()
    {
		go = GameObject.Find ("Player");
		PlayerMovement = go.GetComponent <playerMovement> ();
		speed = PlayerMovement.speed;
		heathen.Set(0, 2, 0);
		moveThis = PlayerMovement.moveThis;
	}
	
    // Update is called once per frame
    void Update()
    {
		heathen = PlayerMovement.heathen;
		float step = speed * Time.deltaTime;
		if (moveThis.position != heathen){
			moveThis.transform.position = Vector3.MoveTowards(moveThis.position, new Vector3(heathen.x, moveThis.position.y, heathen.z), step);
		}
    }
}
