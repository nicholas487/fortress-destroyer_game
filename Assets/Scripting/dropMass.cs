using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropMass : MonoBehaviour 
{
	public Button massDropButton;

	public GameObject massPrefab;
	public GameObject massDropPoint;

	void Start()
	{
		Button btn = massDropButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		massPrefab.transform.position = massDropPoint.transform.position;

		Instantiate(massPrefab);
	}
}