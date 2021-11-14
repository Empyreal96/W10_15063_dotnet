// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.ElementSoundPlayer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  [WebHostHidden]
  [Static(typeof (IElementSoundPlayerStatics), 196608, "Windows.Foundation.UniversalApiContract")]
  public sealed class ElementSoundPlayer : IElementSoundPlayer
  {
    public static extern double Volume { [MethodImpl] get; [MethodImpl] set; }

    public static extern ElementSoundPlayerState State { [MethodImpl] get; [MethodImpl] set; }

    [MethodImpl]
    public static extern void Play(ElementSoundKind sound);
  }
}
