// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.TargetPropertyPath
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Activatable(typeof (ITargetPropertyPathFactory), 65536, "Windows.Foundation.UniversalApiContract")]
  [WebHostHidden]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class TargetPropertyPath : ITargetPropertyPath
  {
    [MethodImpl]
    public extern TargetPropertyPath(DependencyProperty targetProperty);

    [MethodImpl]
    public extern TargetPropertyPath();

    public extern PropertyPath Path { [MethodImpl] get; [MethodImpl] set; }

    public extern object Target { [MethodImpl] get; [MethodImpl] set; }
  }
}
