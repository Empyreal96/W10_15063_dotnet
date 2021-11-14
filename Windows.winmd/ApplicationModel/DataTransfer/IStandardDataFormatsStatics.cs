// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IStandardDataFormatsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [Guid(2127987105, 43136, 16585, 180, 237, 11, 238, 30, 21, 245, 73)]
  [ExclusiveTo(typeof (StandardDataFormats))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IStandardDataFormatsStatics
  {
    string Text { get; }

    string Uri { [Deprecated("Uri may be altered or unavailable for releases after Windows Phone 'OSVersion' (TBD). Instead, use WebLink or ApplicationLink.", DeprecationType.Deprecate, 65536, "Windows.Foundation.UniversalApiContract")] get; }

    string Html { get; }

    string Rtf { get; }

    string Bitmap { get; }

    string StorageItems { get; }
  }
}
