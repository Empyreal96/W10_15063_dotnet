// Decompiled with JetBrains decompiler
// Type: Windows.Media.DialProtocol.IDialDevicePickerFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.DialProtocol
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DialDevicePickerFilter))]
  [Guid(3246166970, 34496, 18525, 184, 214, 15, 154, 143, 100, 21, 144)]
  internal interface IDialDevicePickerFilter
  {
    IVector<string> SupportedAppNames { get; }
  }
}
