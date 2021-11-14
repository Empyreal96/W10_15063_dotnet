// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.TransformGroup
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Markup;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ContentProperty(Name = "Children")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [Static(typeof (ITransformGroupStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class TransformGroup : Transform, ITransformGroup
  {
    [MethodImpl]
    public extern TransformGroup();

    public extern TransformCollection Children { [MethodImpl] get; [MethodImpl] set; }

    public extern Matrix Value { [MethodImpl] get; }

    public static extern DependencyProperty ChildrenProperty { [MethodImpl] get; }
  }
}
