// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DependencyProperty
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;

namespace Windows.UI.Xaml
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Static(typeof (IDependencyPropertyStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class DependencyProperty : IDependencyProperty
  {
    [MethodImpl]
    public extern PropertyMetadata GetMetadata(TypeName forType);

    public static extern object UnsetValue { [MethodImpl] get; }

    [MethodImpl]
    public static extern DependencyProperty Register(
      string name,
      TypeName propertyType,
      TypeName ownerType,
      PropertyMetadata typeMetadata);

    [MethodImpl]
    public static extern DependencyProperty RegisterAttached(
      string name,
      TypeName propertyType,
      TypeName ownerType,
      PropertyMetadata defaultMetadata);
  }
}
