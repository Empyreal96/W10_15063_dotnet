// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplicationStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Controls.Primitives;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(105486743, 63412, 17918, 183, 99, 117, 119, 209, 211, 203, 74)]
  [ExclusiveTo(typeof (Application))]
  [WebHostHidden]
  internal interface IApplicationStatics
  {
    Application Current { get; }

    void Start(ApplicationInitializationCallback callback);

    [Overload("LoadComponent")]
    void LoadComponent(object component, Uri resourceLocator);

    [Overload("LoadComponentWithResourceLocation")]
    void LoadComponent(
      object component,
      Uri resourceLocator,
      ComponentResourceLocation componentResourceLocation);
  }
}
