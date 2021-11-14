// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IItemIndexRangeFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2263008320, 11898, 19581, 166, 100, 232, 171, 240, 123, 252, 126)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ItemIndexRange))]
  internal interface IItemIndexRangeFactory
  {
    ItemIndexRange CreateInstance(
      int firstIndex,
      uint length,
      object outer,
      out object inner);
  }
}
