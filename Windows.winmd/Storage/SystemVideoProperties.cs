// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemVideoProperties
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public sealed class SystemVideoProperties : ISystemVideoProperties
  {
    public extern string Director { [MethodImpl] get; }

    public extern string FrameHeight { [MethodImpl] get; }

    public extern string FrameWidth { [MethodImpl] get; }

    public extern string Orientation { [MethodImpl] get; }

    public extern string TotalBitrate { [MethodImpl] get; }
  }
}
