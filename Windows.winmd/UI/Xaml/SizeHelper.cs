// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.SizeHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Static(typeof (ISizeHelperStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SizeHelper : ISizeHelper
  {
    public static extern Size Empty { [MethodImpl] get; }

    [MethodImpl]
    public static extern Size FromDimensions(float width, float height);

    [MethodImpl]
    public static extern bool GetIsEmpty(Size target);

    [MethodImpl]
    public static extern bool Equals(Size target, Size value);
  }
}
