using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlowText : MonoBehaviour
{
	public TMPro.TMP_Text Text;

	private void Update()
	{
		Text.fontSharedMaterial.SetFloat("_GlowPower", Mathf.Sin(Time.time*10f));
	}
}
