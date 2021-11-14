// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystem
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Guid(3981981901, 7696, 19084, 180, 166, 78, 95, 214, 249, 119, 33)]
  [ExclusiveTo(typeof (RemoteSystem))]
  internal interface IRemoteSystem
  {
    string DisplayName { get; }

    string Id { get; }

    string Kind { get; }

    RemoteSystemStatus Status { get; }

    bool IsAvailableByProximity { get; }
  }
}
