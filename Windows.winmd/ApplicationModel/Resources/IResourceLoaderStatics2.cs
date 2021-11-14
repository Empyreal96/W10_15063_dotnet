// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.IResourceLoaderStatics2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [ExclusiveTo(typeof (ResourceLoader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(213926209, 25702, 18825, 148, 148, 11, 130, 223, 197, 63, 31)]
  internal interface IResourceLoaderStatics2
  {
    [Overload("GetForCurrentView")]
    ResourceLoader GetForCurrentView();

    [Overload("GetForCurrentViewWithName")]
    ResourceLoader GetForCurrentView(string name);

    [Overload("GetForViewIndependentUse")]
    ResourceLoader GetForViewIndependentUse();

    [Overload("GetForViewIndependentUseWithName")]
    ResourceLoader GetForViewIndependentUse(string name);
  }
}
