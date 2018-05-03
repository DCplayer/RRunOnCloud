using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine; 

public class PileButtonFunciton : MonoBehaviour {

	public GameObject TrainOptionButtonPrefab; 
	public GameObject ContenedorOpciones; 

	// Use this for initialization
	void Start () {
        Sprite button = Resources.Load<Sprite>("Buttons/UI_Button_Standard_Orange");
		Sprite[] thumbnails = Resources.LoadAll<Sprite> ("ICTB"); 
		foreach (Sprite thumbnail in thumbnails) 
		{
            GameObject container = Instantiate(TrainOptionButtonPrefab) as GameObject; 
			container.GetComponent<Image> ().sprite = thumbnail; 
			container.transform.SetParent (ContenedorOpciones.transform, false); 
		}
	}

}
