// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.DependencyObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Xaml
{
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Composable(typeof (IDependencyObjectFactory), CompositionType.Protected, 65536, "Windows.Foundation.UniversalApiContract")]
  public class DependencyObject : IDependencyObject, IDependencyObject2
  {
    [MethodImpl]
    protected extern DependencyObject();

    [MethodImpl]
    public extern object GetValue(DependencyProperty dp);

    [MethodImpl]
    public extern void SetValue(DependencyProperty dp, object value);

    [MethodImpl]
    public extern void ClearValue(DependencyProperty dp);

    [MethodImpl]
    public extern object ReadLocalValue(DependencyProperty dp);

    [MethodImpl]
    public extern object GetAnimationBaseValue(DependencyProperty dp);

    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    [MethodImpl]
    public extern long RegisterPropertyChangedCallback(
      DependencyProperty dp,
      DependencyPropertyChangedCallback callback);

    [MethodImpl]
    public extern void UnregisterPropertyChangedCallback(DependencyProperty dp, long token);
  }
}
