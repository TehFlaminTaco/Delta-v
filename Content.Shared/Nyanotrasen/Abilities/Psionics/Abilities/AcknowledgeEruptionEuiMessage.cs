using Content.Shared.Eui;
using Robust.Shared.Serialization;

namespace Content.Shared.Psionics
{
    [Serializable, NetSerializable]
    public sealed class AcknowledgeEruptionEuiMessage : EuiMessageBase
    {
        public AcknowledgeEruptionEuiMessage()
        {
        }
    }
}
