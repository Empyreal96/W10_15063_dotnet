// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IPathFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(591439075, 23174, 20422, 154, 80, 203, 185, 59, 130, 135, 102)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Path))]
  internal interface IPathFactory
  {
    Path CreateInstance(object outer, out object inner);
  }
}
