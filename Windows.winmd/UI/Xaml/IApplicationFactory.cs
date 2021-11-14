// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IApplicationFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2478564193, 48730, 20195, 180, 163, 149, 17, 141, 201, 122, 137)]
  [ExclusiveTo(typeof (Application))]
  [WebHostHidden]
  internal interface IApplicationFactory
  {
    Application CreateInstance(object outer, out object inner);
  }
}
