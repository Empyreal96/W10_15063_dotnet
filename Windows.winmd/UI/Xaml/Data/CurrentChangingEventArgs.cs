// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Data.CurrentChangingEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Data
{
  [Composable(typeof (ICurrentChangingEventArgsFactory), CompositionType.Public, 65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  public class CurrentChangingEventArgs : ICurrentChangingEventArgs
  {
    [MethodImpl]
    public extern CurrentChangingEventArgs();

    [MethodImpl]
    public extern CurrentChangingEventArgs(bool isCancelable);

    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    public extern bool IsCancelable { [MethodImpl] get; }
  }
}
