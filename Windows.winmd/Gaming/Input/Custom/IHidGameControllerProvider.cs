// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.Custom.IHidGameControllerProvider
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input.Custom
{
  [Guid(2513320692, 44016, 19304, 160, 129, 59, 125, 231, 63, 240, 231)]
  [ExclusiveTo(typeof (HidGameControllerProvider))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  internal interface IHidGameControllerProvider : IGameControllerProvider
  {
    ushort UsageId { get; }

    ushort UsagePage { get; }

    void GetFeatureReport(byte reportId, [Out] byte[] reportBuffer);

    void SendFeatureReport(byte reportId, byte[] reportBuffer);

    void SendOutputReport(byte reportId, byte[] reportBuffer);
  }
}
