// Decompiled with JetBrains decompiler
// Type: Windows.Media.Audio.IAudioInputNode
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Audio
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3511156828, 33832, 18308, 183, 253, 169, 157, 70, 140, 93, 32)]
  public interface IAudioInputNode : IAudioNode, IClosable
  {
    IVectorView<AudioGraphConnection> OutgoingConnections { get; }

    [Overload("AddOutgoingConnection")]
    void AddOutgoingConnection(IAudioNode destination);

    [Overload("AddOutgoingConnectionWithGain")]
    void AddOutgoingConnection(IAudioNode destination, double gain);

    void RemoveOutgoingConnection(IAudioNode destination);
  }
}
