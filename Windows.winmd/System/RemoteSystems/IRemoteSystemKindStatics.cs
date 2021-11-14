// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemKindStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ExclusiveTo(typeof (RemoteSystemKinds))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(4130436659, 43796, 16848, 149, 83, 121, 106, 173, 184, 130, 219)]
  internal interface IRemoteSystemKindStatics
  {
    string Phone { get; }

    string Hub { get; }

    string Holographic { get; }

    string Desktop { get; }

    string Xbox { get; }
  }
}
