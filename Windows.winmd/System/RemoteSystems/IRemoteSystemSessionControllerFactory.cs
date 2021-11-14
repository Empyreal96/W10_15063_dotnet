// Decompiled with JetBrains decompiler
// Type: Windows.System.RemoteSystems.IRemoteSystemSessionControllerFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System.RemoteSystems
{
  [Guid(3217829739, 44093, 16793, 130, 205, 102, 112, 167, 115, 239, 46)]
  [ExclusiveTo(typeof (RemoteSystemSessionController))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IRemoteSystemSessionControllerFactory
  {
    [Overload("CreateController")]
    RemoteSystemSessionController CreateController(string displayName);

    [Overload("CreateControllerWithSessionOptions")]
    RemoteSystemSessionController CreateController(
      string displayName,
      RemoteSystemSessionOptions options);
  }
}
