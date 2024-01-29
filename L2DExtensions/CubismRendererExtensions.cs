using Vector3 = UnityEngine.Vector3;

using CubismRenderer = Live2D.Cubism.Rendering.CubismRenderer;

using static PHATASS.Utils.Extensions.MeshExtensions;

namespace PHATASS.L2DTools.Extensions
{
	public static class CubismRendererExtensions
	{
	// Gets the centroid position
		public static Vector3 EGetMeshCentroid (this CubismRenderer cubismRenderer, bool worldSpace = true)
		{
			if (worldSpace)
			{
				return cubismRenderer.transform.TransformPoint(
					cubismRenderer.Mesh.EGetCentroid());
			}
			return cubismRenderer.Mesh.EGetCentroid();
		}
	}
}