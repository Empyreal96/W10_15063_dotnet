// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.Input.IHeadset
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.Input
{
  [Guid(1070683887, 26917, 16296, 145, 129, 2, 156, 82, 35, 174, 59)]
  [ExclusiveTo(typeof (Headset))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IHeadset
  {
    string CaptureDeviceId { get; }

    string RenderDeviceId { get; }
  }
}
