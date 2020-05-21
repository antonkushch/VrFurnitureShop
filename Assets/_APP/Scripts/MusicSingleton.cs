using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace AssemblyCSharp
{
	public class MusicSingleton : MonoBehaviour
	{
		public AudioSource _audioSource;

		private static MusicSingleton instance = null;
		public static MusicSingleton Instance {
			get { return instance; }
		}

		void Awake() {
			_audioSource = GetComponent<AudioSource>();
			if (instance != null && instance != this) {
				Destroy(this.gameObject);
				return;
			} else {
				instance = this;
			}
			DontDestroyOnLoad(this.gameObject);
		}
	}
}

