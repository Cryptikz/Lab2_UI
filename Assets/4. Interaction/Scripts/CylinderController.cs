using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
	public float TargetSize = 1f;

	public void SetSize(int sizeChoice)
	{
		switch(sizeChoice)
		{
			case 0:
				TargetSize = 1f;
				break;
			case 1:
				TargetSize = 2f;
				break;
			case 2:
				TargetSize = 3f;
				break;
			default:
				TargetSize = 1f;
				break;
		}
	}

	private void Update()
	{
		transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one * TargetSize, Time.deltaTime);
	}
}
