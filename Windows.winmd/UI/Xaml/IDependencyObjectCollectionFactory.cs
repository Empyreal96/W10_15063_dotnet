// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDependencyObjectCollectionFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (DependencyObjectCollection))]
  [WebHostHidden]
  [Guid(85883391, 45992, 18926, 181, 175, 172, 143, 104, 182, 73, 228)]
  internal interface IDependencyObjectCollectionFactory
  {
    DependencyObjectCollection CreateInstance(
      object outer,
      out object inner);
  }
}
