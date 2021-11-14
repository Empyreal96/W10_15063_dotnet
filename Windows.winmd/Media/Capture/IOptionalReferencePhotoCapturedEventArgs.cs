// Decompiled with JetBrains decompiler
// Type: Windows.Media.Capture.IOptionalReferencePhotoCapturedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Capture
{
  [Guid(1192200371, 7789, 16465, 156, 139, 241, 216, 90, 240, 71, 183)]
  [ExclusiveTo(typeof (OptionalReferencePhotoCapturedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IOptionalReferencePhotoCapturedEventArgs
  {
    CapturedFrame Frame { get; }

    object Context { get; }
  }
}
