﻿using UtinyRipper.AssetExporters;
using UtinyRipper.Exporter.YAML;

namespace UtinyRipper.Classes.AnimatorControllers.Editor
{
	public sealed class ChildAnimatorStateMachine : IYAMLExportable
	{
		private static int GetSerializedVersion(Version version)
		{
#warning TODO: serialized version acording to read version (current 2017.3.0f3)
			return 1;
		}

		public YAMLNode ExportYAML(IAssetsExporter exporter)
		{
			YAMLMappingNode node = new YAMLMappingNode();
			node.AddSerializedVersion(GetSerializedVersion(exporter.Version));
			node.Add("m_StateMachine", StateMachine.ExportYAML(exporter));
			node.Add("m_Position", Position.ExportYAML(exporter));
			return node;
		}

		public PPtr<AnimatorStateMachine> StateMachine;
		public Vector3f Position;
	}
}
