// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IProjectionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [Guid(3304234155, 24749, 20260, 189, 39, 157, 105, 195, 18, 124, 154)]
  [ExclusiveTo(typeof (Projection))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IProjectionFactory
  {
    Projection CreateInstance(object outer, out object inner);
  }
}
