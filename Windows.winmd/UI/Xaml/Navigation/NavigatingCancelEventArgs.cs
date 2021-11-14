// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Navigation.NavigatingCancelEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Interop;
using Windows.UI.Xaml.Media.Animation;

namespace Windows.UI.Xaml.Navigation
{
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class NavigatingCancelEventArgs : 
    INavigatingCancelEventArgs,
    INavigatingCancelEventArgs2
  {
    public extern bool Cancel { [MethodImpl] get; [MethodImpl] set; }

    public extern NavigationMode NavigationMode { [MethodImpl] get; }

    public extern TypeName SourcePageType { [MethodImpl] get; }

    public extern object Parameter { [MethodImpl] get; }

    public extern NavigationTransitionInfo NavigationTransitionInfo { [MethodImpl] get; }
  }
}
