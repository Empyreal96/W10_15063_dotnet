// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IShareProvider
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
  [Guid(799793190, 17470, 19674, 175, 37, 141, 129, 7, 14, 253, 128)]
  internal interface IShareProvider
  {
    string Title { get; }

    RandomAccessStreamReference DisplayIcon { get; }

    Color BackgroundColor { get; }

    object Tag { get; set; }
  }
}
