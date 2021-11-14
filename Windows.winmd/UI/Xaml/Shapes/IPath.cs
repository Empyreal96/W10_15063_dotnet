// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.IPath
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media;

namespace Windows.UI.Xaml.Shapes
{
  [Guid(2022192649, 15703, 20284, 184, 165, 108, 171, 202, 201, 113, 31)]
  [ExclusiveTo(typeof (Path))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  internal interface IPath
  {
    Geometry Data { get; set; }
  }
}
