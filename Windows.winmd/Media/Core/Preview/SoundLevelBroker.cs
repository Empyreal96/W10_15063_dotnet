// Decompiled with JetBrains decompiler
// Type: Windows.Media.Core.Preview.SoundLevelBroker
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Core.Preview
{
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [Static(typeof (ISoundLevelBrokerStatics), 262144, "Windows.Foundation.UniversalApiContract")]
  public static class SoundLevelBroker
  {
    public static extern SoundLevel SoundLevel { [MethodImpl] get; }

    public static extern event EventHandler<object> SoundLevelChanged;
  }
}
