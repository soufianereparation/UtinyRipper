﻿using System;
using UtinyRipper.Exporter.YAML;
using Object = UtinyRipper.Classes.Object;

namespace UtinyRipper.AssetExporters.Classes
{
	public class NativeFormatImporter : DefaultImporter
	{
		public NativeFormatImporter(UtinyRipper.Classes.Object mainObject)
		{
			if(mainObject == null)
			{
				throw new ArgumentNullException(nameof(mainObject));
			}
			m_mainObject = mainObject;
		}

		protected override void ExportYAMLInner(IAssetsExporter exporter, YAMLMappingNode node)
		{
			node.Add("mainObjectFileID", exporter.GetExportID(m_mainObject));
		}

		private readonly UtinyRipper.Classes.Object m_mainObject;
	}
}
