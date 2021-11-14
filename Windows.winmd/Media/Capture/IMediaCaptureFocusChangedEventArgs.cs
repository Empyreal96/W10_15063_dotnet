// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IMediaCaptureFocusChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Devices;

namespace Windows.Media.Capture
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2179054719, 8823, 18750, 171, 238, 211, 244, 79, 249, 140, 4)]
  [ExclusiveTo(typeof (MediaCaptureFocusChangedEventArgs))]
  internal interface IMediaCaptureFocusChangedEventArgs
  {
    MediaCaptureFocusState FocusState { get; }
  }
}
