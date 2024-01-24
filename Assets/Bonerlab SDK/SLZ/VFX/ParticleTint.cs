using SLZ.Marrow.Pool;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.VFX
{
	public class ParticleTint : SpawnEvents
	{
		private static ComponentCache<ParticleTint> _cache;

		[Space]
		[SerializeField]
		[Header("This is used to tint particels when they are spawned in")]
		private ParticleSystem[] ParticleSystems;

		[SerializeField]
		private Renderer[] Renderers;

		[SerializeField]
		private AudioSource audioSource;

		private int[] burstCount;

		[SerializeField]
		private Mesh quadRef;

		public static ComponentCache<ParticleTint> Cache => null;

		private void Reset()
		{
		}

		protected override void OnPostSpawn(GameObject go)
		{
		}

		public void PlaySystems()
		{
		}

		public void PlaySFX()
		{
		}

		public void TintParticles(Color TintColor)
		{
		}

		public void SetTargetMesh(Mesh mesh)
		{
		}

		public void SetTargetMesh(Mesh mesh, Vector3 scale)
		{
		}

		public void SetTargetMeshRenderer(MeshRenderer meshRenderer)
		{
		}

		public void SetTargetSkinnedMesh(SkinnedMeshRenderer meshRenderer)
		{
		}

		public void ScaleParticleSphere(float Radius)
		{
		}

		public void SetParticleBurstCount(int count)
		{
		}

		public void ScaleParticleBurstCount(float scale)
		{
		}

		public void ResetParticleBurstCount()
		{
		}

		public void SetMeshAndPlay(Color TintColor, Mesh mesh, float volumeSize, Vector3 scale, Vector3? velocity = null)
		{
		}

		public void SetMeshAndPlay(Color TintColor, SkinnedMeshRenderer mesh, float volumeSize, Vector3 scale, Vector3? velocity = null)
		{
		}

		public void SetForceField(ParticleSystemForceField forceField, float lifeTime)
		{
		}

		public void SetQuadAsMeshEmitterAndStop()
		{
		}

		private float GetVolume(Vector3 size)
		{
			return 0f;
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
