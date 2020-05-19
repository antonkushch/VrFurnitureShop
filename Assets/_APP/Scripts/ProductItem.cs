using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AssemblyCSharp
{
	public class ProductItem : MonoBehaviour
	{
		public Animator scaleAnimation;

		void Start()
		{
			scaleAnimation.GetComponents<Animator>();
		}

		public void StartScaleGoHere()
		{
			for (int i = 0; i < this.transform.childCount; i++)
			{
				var child = this.transform.GetChild(i).gameObject;
				if (child != null) 
				{
					child.SetActive (true);
				}
			}
			scaleAnimation.Play("GoHereAnimation");
		}
		public void StopScaleGoHere()
		{
			for (int i = 0; i < this.transform.childCount; i++)
			{
				var child = this.transform.GetChild(i).gameObject;
				if (child != null) 
				{
					child.SetActive (false);
				}
			}
			scaleAnimation.Play("none");
		}
		public void ShowTooltip()
		{
			for (int i = 0; i < this.transform.childCount; i++)
			{
				var child = this.transform.GetChild(i).gameObject;
				if (child != null) 
				{
					if (child.activeSelf)
						child.SetActive (false);
					else
						child.SetActive (true);
				}
			}
		}
	}
}

