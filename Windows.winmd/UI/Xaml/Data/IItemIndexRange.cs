// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.IItemIndexRange
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ItemIndexRange))]
  [Guid(2209887422, 1411, 18982, 155, 100, 139, 244, 162, 246, 87, 4)]
  internal interface IItemIndexRange
  {
    int FirstIndex { get; }

    uint Length { get; }

    int LastIndex { get; }
  }
}
