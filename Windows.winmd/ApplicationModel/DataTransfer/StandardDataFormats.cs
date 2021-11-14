// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.StandardDataFormats
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [DualApiPartition(version = 100794368)]
  [Static(typeof (IStandardDataFormatsStatics2), 65536, "Windows.Foundation.UniversalApiContract")]
  [Static(typeof (IStandardDataFormatsStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class StandardDataFormats
  {
    public static extern string WebLink { [MethodImpl] get; }

    public static extern string ApplicationLink { [MethodImpl] get; }

    public static extern string Text { [MethodImpl] get; }

    public static extern string Uri { [Deprecated("Uri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use WebLink or ApplicationLink.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract"), MethodImpl] get; }

    public static extern string Html { [MethodImpl] get; }

    public static extern string Rtf { [MethodImpl] get; }

    public static extern string Bitmap { [MethodImpl] get; }

    public static extern string StorageItems { [MethodImpl] get; }
  }
}
