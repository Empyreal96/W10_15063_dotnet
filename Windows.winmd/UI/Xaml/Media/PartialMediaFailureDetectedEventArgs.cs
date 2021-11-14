// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.PartialMediaFailureDetectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.UI.Xaml.Media
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  public sealed class PartialMediaFailureDetectedEventArgs : 
    IPartialMediaFailureDetectedEventArgs,
    IPartialMediaFailureDetectedEventArgs2
  {
    [MethodImpl]
    public extern PartialMediaFailureDetectedEventArgs();

    public extern FailedMediaStreamKind StreamKind { [MethodImpl] get; }

    public extern HResult ExtendedError { [MethodImpl] get; }
  }
}
