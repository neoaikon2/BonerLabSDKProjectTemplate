using System;
using SLZ.Zones;
using UnityEngine;

namespace SLZ.Bonelab
{
	[Serializable]
	public class ZoneDisplayEditor
	{
		public SceneZone sZone;

		public string zoneTitle;

		public Rect zoneRect;

		public Rect[] rowRects;

		public int buttonCount;

		public int buttonBuffer;

		public int rowCount;

		public int rowMax;

		public int currRow;

		public bool showZoneDisplay;

		public bool showDebug;
	}
}
