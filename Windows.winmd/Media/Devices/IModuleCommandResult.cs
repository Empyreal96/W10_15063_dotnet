// Decompiled with JetBrains decompiler
// Type: Windows.Media.Devices.IModuleCommandResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Media.Devices
{
  [ExclusiveTo(typeof (ModuleCommandResult))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(1376591540, 4980, 19581, 177, 228, 57, 220, 223, 62, 174, 78)]
  internal interface IModuleCommandResult
  {
    SendCommandStatus Status { get; }

    IBuffer Result { get; }
  }
}
