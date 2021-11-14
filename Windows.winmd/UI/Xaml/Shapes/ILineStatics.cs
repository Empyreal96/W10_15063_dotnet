// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Shapes.ILineStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Shapes
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(645665341, 28324, 19536, 139, 29, 80, 32, 122, 255, 30, 138)]
  [WebHostHidden]
  [ExclusiveTo(typeof (Line))]
  internal interface ILineStatics
  {
    DependencyProperty X1Property { get; }

    DependencyProperty Y1Property { get; }

    DependencyProperty X2Property { get; }

    DependencyProperty Y2Property { get; }
  }
}
