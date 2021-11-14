// Decompiled with JetBrains decompiler
// Type: Windows.Perception.PerceptionTimestampHelper
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Perception
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [Static(typeof (IPerceptionTimestampHelperStatics), 131072, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [Threading(ThreadingModel.Both)]
  public static class PerceptionTimestampHelper
  {
    [MethodImpl]
    public static extern PerceptionTimestamp FromHistoricalTargetTime(
      DateTime targetTime);
  }
}
