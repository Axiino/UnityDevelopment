﻿using UnityEngine;
using System.Collections;

public class TrianglePlayer : PlayerManager
{

	override public void Set_Avatar () 
	{
		spr = Resources.Load<Sprite>("Sprites/triangle");
		//spr.textureRect.size = new Vector2(10.0f, 5.0f);
		GetComponent<SpriteRenderer> ().sprite = spr;
		transform.localScale = new Vector2 (0.5f, 0.5f);
	}

	override public void UpdateSpeed () {
	//speed = speed + 0.00000025f;
	if (isAlive == false) {
		speed = 0;
		}
	else if (speed >= MaxSpeed/2 && isAlive == true)
			speed = speed + Mathf.Pow(2,speed + 2.5f) / 10000000;

	else if (speed <= MaxSpeed && isAlive == true)
			speed = speed + (speed + 2.5f)/10000000;
	}
}

