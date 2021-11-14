// Decompiled with JetBrains decompiler
// Type: Windows.System.Profile.SystemIdentificationInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.System.Profile
{
  [MarshalingBehavior(MarshalingType.Agile)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [Threading(ThreadingModel.Both)]
  public sealed class SystemIdentificationInfo : ISystemIdentificationInfo
  {
    public extern IBuffer Id { [MethodImpl] get; }

    public extern SystemIdentificationSource Source { [MethodImpl] get; }
  }
}
