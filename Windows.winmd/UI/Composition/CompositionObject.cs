// Decompiled with JetBrains decompiler
// Type: Windows.UI.Composition.CompositionObject
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Core;

namespace Windows.UI.Composition
{
  [WebHostHidden]
  [Composable(typeof (ICompositionObjectFactory), CompositionType.Protected, 131072, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class CompositionObject : ICompositionObject, IClosable, ICompositionObject2
  {
    public extern Compositor Compositor { [MethodImpl] get; }

    public extern CoreDispatcher Dispatcher { [MethodImpl] get; }

    public extern CompositionPropertySet Properties { [MethodImpl] get; }

    [MethodImpl]
    public extern void StartAnimation(string propertyName, CompositionAnimation animation);

    [MethodImpl]
    public extern void StopAnimation(string propertyName);

    [MethodImpl]
    public extern void Close();

    public extern string Comment { [MethodImpl] get; [MethodImpl] set; }

    public extern ImplicitAnimationCollection ImplicitAnimations { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public extern void StartAnimationGroup(ICompositionAnimationBase value);

    [MethodImpl]
    public extern void StopAnimationGroup(ICompositionAnimationBase value);
  }
}
