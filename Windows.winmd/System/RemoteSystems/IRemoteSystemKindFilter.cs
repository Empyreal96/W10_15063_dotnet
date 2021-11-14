// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemKindFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemKindFilter))]
  [Guid(954321388, 8899, 20214, 144, 26, 187, 177, 199, 170, 212, 237)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IRemoteSystemKindFilter
  {
    IVectorView<string> RemoteSystemKinds { get; }
  }
}
