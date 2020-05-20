using System;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AssemblyCSharp
{
	public class IntroGoToText : MonoBehaviour
	{
		public GameObject current;

		void Start()
		{
			
			//scaleAnimation.GetComponents<Animator>();
		}

		public void StartScaleGoHere()
		{
			for (int i = 0; i < current.transform.childCount; i++)
			{
				var child = current.transform.GetChild(i).gameObject;
				var anim = child.GetComponent<Animator> ();
				if (anim == null)
					continue;
				anim.Play("GoHereAnimation");
			}
			//scaleAnimation.Play("GoHereAnimation");
		}
		public void StopScaleGoHere()
		{
			//scaleAnimation.Play("none");
			for (int i = 0; i < current.transform.childCount; i++)
			{
				var child = current.transform.GetChild(i).gameObject;
				var anim = child.GetComponent<Animator> ();
				if (anim == null)
					continue;
				anim.Play("none");
			}
		}
	}
}

