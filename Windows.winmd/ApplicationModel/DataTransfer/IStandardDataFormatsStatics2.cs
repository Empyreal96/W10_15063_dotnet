// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IStandardDataFormatsStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1117934836, 40310, 17128, 134, 27, 71, 194, 93, 208, 207, 113)]
  [ExclusiveTo(typeof (StandardDataFormats))]
  internal interface IStandardDataFormatsStatics2
  {
    string WebLink { get; }

    string ApplicationLink { get; }
  }
}
