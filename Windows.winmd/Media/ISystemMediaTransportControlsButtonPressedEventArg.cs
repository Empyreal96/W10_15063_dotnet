// Decompiled with JetBrains decompiler
// Type: Windows.Media.ISystemMediaTransportControlsButtonPressedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media
{
  [Guid(3086250262, 42351, 19912, 158, 17, 146, 3, 31, 74, 135, 194)]
  [ExclusiveTo(typeof (SystemMediaTransportControlsButtonPressedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface ISystemMediaTransportControlsButtonPressedEventArgs
  {
    SystemMediaTransportControlsButton Button { get; }
  }
}
