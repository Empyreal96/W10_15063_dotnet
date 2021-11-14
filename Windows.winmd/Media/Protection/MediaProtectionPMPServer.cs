// Decompiled with JetBrains decompiler
// Type: Windows.Media.Protection.MediaProtectionPMPServer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Protection
{
  [Threading(ThreadingModel.Both)]
  [Activatable(typeof (IMediaProtectionPMPServerFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class MediaProtectionPMPServer : IMediaProtectionPMPServer
  {
    [MethodImpl]
    public extern MediaProtectionPMPServer(IPropertySet pProperties);

    public extern IPropertySet Properties { [MethodImpl] get; }
  }
}
