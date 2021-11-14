// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.ShareTarget.IShareOperation2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer.ShareTarget
{
  [ExclusiveTo(typeof (ShareOperation))]
  [Guid(268146625, 38776, 18953, 142, 91, 203, 94, 72, 45, 5, 85)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IShareOperation2
  {
    void DismissUI();
  }
}
