using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AssemblyCSharp
{
	public class BuyButton : MonoBehaviour
	{
		public string Url;

		public void Open()
		{
			Application.OpenURL (Url);
		}
	}
}

