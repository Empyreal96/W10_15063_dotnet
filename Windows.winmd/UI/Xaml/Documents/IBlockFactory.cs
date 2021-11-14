// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IBlockFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ExclusiveTo(typeof (Block))]
  [Guid(118555954, 20313, 20283, 156, 229, 37, 120, 76, 67, 5, 7)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IBlockFactory
  {
    Block CreateInstance(object outer, out object inner);
  }
}
