// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingDevicePickerFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (CastingDevicePickerFilter))]
  [Guid(3196871068, 46435, 17236, 174, 51, 159, 218, 173, 140, 98, 145)]
  internal interface ICastingDevicePickerFilter
  {
    bool SupportsAudio { get; set; }

    bool SupportsVideo { get; set; }

    bool SupportsPictures { get; set; }

    IVector<CastingSource> SupportedCastingSources { get; }
  }
}
