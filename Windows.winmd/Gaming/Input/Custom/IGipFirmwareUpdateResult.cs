// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IGipFirmwareUpdateResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [Guid(1803111730, 34131, 17042, 142, 3, 225, 102, 81, 162, 248, 188)]
  [ExclusiveTo(typeof (GipFirmwareUpdateResult))]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IGipFirmwareUpdateResult
  {
    uint ExtendedErrorCode { get; }

    uint FinalComponentId { get; }

    GipFirmwareUpdateStatus Status { get; }
  }
}
