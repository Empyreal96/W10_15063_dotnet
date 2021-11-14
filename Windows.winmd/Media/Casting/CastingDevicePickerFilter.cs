// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.CastingDevicePickerFilter
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [DualApiPartition(version = 167772160)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class CastingDevicePickerFilter : ICastingDevicePickerFilter
  {
    public extern bool SupportsAudio { [MethodImpl] get; [MethodImpl] set; }

    public extern bool SupportsVideo { [MethodImpl] get; [MethodImpl] set; }

    public extern bool SupportsPictures { [MethodImpl] get; [MethodImpl] set; }

    public extern IVector<CastingSource> SupportedCastingSources { [MethodImpl] get; }
  }
}
