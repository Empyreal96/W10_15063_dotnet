// Decompiled with JetBrains decompiler
// Type: Windows.Phone.Media.Capture.VendorSpecificDataEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System;
using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Phone.Media.Capture
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract")]
  [WebHostHidden]
  [ContractVersion(typeof (PhoneInternalContract), 65536)]
  public sealed class VendorSpecificDataEventArgs : IVendorSpecificDataEventArgs
  {
    public extern Guid EventId { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] get; }

    public extern object Data { [Deprecated("Windows.Phone.Media.Capture may not be available in future versions of Windows Phone. Starting with Windows Phone Blue, use Windows.Media.Capture instead", DeprecationType.Deprecate, 65536, "Windows.Phone.PhoneInternalContract"), MethodImpl] [return: Variant] get; }
  }
}
