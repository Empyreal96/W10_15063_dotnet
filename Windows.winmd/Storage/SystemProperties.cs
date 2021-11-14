// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (ISystemProperties), 65536, "Windows.Foundation.UniversalApiContract")]
  public static class SystemProperties
  {
    public static extern string Author { [MethodImpl] get; }

    public static extern string Comment { [MethodImpl] get; }

    public static extern string ItemNameDisplay { [MethodImpl] get; }

    public static extern string Keywords { [MethodImpl] get; }

    public static extern string Rating { [MethodImpl] get; }

    public static extern string Title { [MethodImpl] get; }

    public static extern SystemAudioProperties Audio { [MethodImpl] get; }

    public static extern SystemGPSProperties GPS { [MethodImpl] get; }

    public static extern SystemMediaProperties Media { [MethodImpl] get; }

    public static extern SystemMusicProperties Music { [MethodImpl] get; }

    public static extern SystemPhotoProperties Photo { [MethodImpl] get; }

    public static extern SystemVideoProperties Video { [MethodImpl] get; }

    public static extern SystemImageProperties Image { [MethodImpl] get; }
  }
}
