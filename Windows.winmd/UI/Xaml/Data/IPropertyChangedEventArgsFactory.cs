// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IPropertyChangedEventArgsFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (PropertyChangedEventArgs))]
  [WebHostHidden]
  [Guid(1842125827, 57543, 20206, 142, 169, 55, 227, 64, 110, 235, 28)]
  internal interface IPropertyChangedEventArgsFactory
  {
    PropertyChangedEventArgs CreateInstance(
      string name,
      object outer,
      out object inner);
  }
}
