// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplicationOverrides2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (Application))]
  [Guid(3680293561, 54196, 21900, 198, 78, 4, 52, 253, 27, 216, 137)]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  internal interface IApplicationOverrides2
  {
    void OnBackgroundActivated(BackgroundActivatedEventArgs args);
  }
}
