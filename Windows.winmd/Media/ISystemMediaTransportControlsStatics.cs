// Decompiled with JetBrains decompiler
// Type: Windows.Media.ISystemMediaTransportControlsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1136277514, 60580, 18482, 145, 171, 212, 21, 250, 228, 132, 198)]
  [ExclusiveTo(typeof (SystemMediaTransportControls))]
  internal interface ISystemMediaTransportControlsStatics
  {
    SystemMediaTransportControls GetForCurrentView();
  }
}
