// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareProviderFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;
using Windows.UI;

namespace Windows.ApplicationModel.DataTransfer
{
  [ExclusiveTo(typeof (ShareProvider))]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Guid(388634444, 59294, 20333, 176, 125, 18, 143, 70, 158, 2, 150)]
  internal interface IShareProviderFactory
  {
    ShareProvider Create(
      string title,
      RandomAccessStreamReference displayIcon,
      Color backgroundColor,
      ShareProviderHandler handler);
  }
}
