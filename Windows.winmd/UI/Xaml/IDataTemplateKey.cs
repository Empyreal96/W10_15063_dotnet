// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IDataTemplateKey
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ExclusiveTo(typeof (DataTemplateKey))]
  [WebHostHidden]
  [Guid(2268818472, 52459, 19297, 134, 250, 178, 206, 195, 156, 194, 250)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IDataTemplateKey
  {
    object DataType { get; set; }
  }
}
