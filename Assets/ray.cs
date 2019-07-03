using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class ray : MonoBehaviour{

	//public GameObject player;
	//public GameObject prefab;
	//Color red = Color.red;
	void Start(){

  }


	void Update(){
		if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began){
			Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
			RaycastHit Hit;

			if(Physics.Raycast(ray, out Hit)){
					string Nombre = Hit.transform.name;
					switch(Nombre){
						case "cap1":
							Debug.Log(Nombre);
							//SceneManager.LoadScene("end");
							//Destroy(player,7);
							//Instantiate(prefab, new Vector3(0,5,0),Quaternion.identity);
						break;
					}
			}
		}
  }
}
