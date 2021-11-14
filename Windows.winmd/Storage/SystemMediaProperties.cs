// Decompiled with JetBrains decompiler
// Type: Windows.Storage.SystemMediaProperties
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
  public sealed class SystemMediaProperties : ISystemMediaProperties
  {
    public extern string Duration { [MethodImpl] get; }

    public extern string Producer { [MethodImpl] get; }

    public extern string Publisher { [MethodImpl] get; }

    public extern string SubTitle { [MethodImpl] get; }

    public extern string Writer { [MethodImpl] get; }

    public extern string Year { [MethodImpl] get; }
  }
}
