using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
	Material material;

	bool isDissolving = false;
	float fade = 1f;

	void Start()
	{
		// Get a reference to the material
		material = GetComponent<SpriteRenderer>().material;
	}

	/// <summary>
	/// Clicking the left mouse button will make the player turn invisible
	/// </summary>
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			isDissolving = true;
		}

		if (isDissolving)
		{
			//The dissolve will take time to be in effect
			//Does an animation triggering it
			fade -= Time.deltaTime;

			if (fade <= 0f)
			{
				fade = 0f;
				isDissolving = false;
			}

			// Set the property
			material.SetFloat("_Fade", fade);
		}
	}
}
