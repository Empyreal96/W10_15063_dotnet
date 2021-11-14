// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.GeometryGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ContentProperty(Name = "Children")]
  [Static(typeof (IGeometryGroupStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  public sealed class GeometryGroup : Geometry, IGeometryGroup
  {
    [MethodImpl]
    public extern GeometryGroup();

    public extern FillRule FillRule { [MethodImpl] get; [MethodImpl] set; }

    public extern GeometryCollection Children { [MethodImpl] get; [MethodImpl] set; }

    public static extern DependencyProperty FillRuleProperty { [MethodImpl] get; }

    public static extern DependencyProperty ChildrenProperty { [MethodImpl] get; }
  }
}
