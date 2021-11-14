// Decompiled with JetBrains decompiler
// Type: Windows.Networking.BackgroundTransfer.IBackgroundTransferErrorStaticMethods
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web;

namespace Windows.Networking.BackgroundTransfer
{
  [ExclusiveTo(typeof (BackgroundTransferError))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2865969924, 4498, 19444, 139, 104, 57, 197, 173, 210, 68, 226)]
  internal interface IBackgroundTransferErrorStaticMethods
  {
    WebErrorStatus GetStatus(int hresult);
  }
}
