using UnityEngine;

namespace SLZ.Bonelab
{
	[RequireComponent(typeof(Light))]
	public class lightGradientAnimation : MonoBehaviour
	{
		private Light light;

		public Gradient gradient;

		public float animationTime;

		private void Awake()
		{
		}

		private void Update()
		{
		}
	}
}
