using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
	public Vector3 RotationSpeed;

	public void SetRotationSpeedX(float x)
	{
		RotationSpeed.x = x;
	}
	public void SetRotationSpeedY(float y)
	{
		RotationSpeed.y = y;
	}

	public void SetRotationSpeedZ(float z)
	{
		RotationSpeed.z = z;
	}

	private void Update()
	{
		transform.Rotate(RotationSpeed * Time.deltaTime);
	}
}
