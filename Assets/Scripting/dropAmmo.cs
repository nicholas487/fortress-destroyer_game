using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dropAmmo : MonoBehaviour 
{
	public Button ammoDropButton;

	public GameObject ammoPrefab;
	public GameObject ammoDropPoint;

	void Start()
	{
		Button btn = ammoDropButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		ammoPrefab.transform.position = ammoDropPoint.transform.position;

		Instantiate(ammoPrefab);
	}
}