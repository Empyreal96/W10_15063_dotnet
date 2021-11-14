// Decompiled with JetBrains decompiler
// Type: Windows.UI.ViewManagement.IStatusBarProgressIndicator
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Phone;

namespace Windows.UI.ViewManagement
{
  [ContractVersion(typeof (PhoneContract), 65536)]
  [Guid(1993025136, 41943, 18895, 130, 0, 79, 62, 237, 202, 39, 187)]
  [ExclusiveTo(typeof (StatusBarProgressIndicator))]
  internal interface IStatusBarProgressIndicator
  {
    [RemoteAsync]
    IAsyncAction ShowAsync();

    [RemoteAsync]
    IAsyncAction HideAsync();

    string Text { get; set; }

    IReference<double> ProgressValue { get; set; }
  }
}
