// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Calls.PhoneLineConfiguration
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Calls
{
  [Threading(ThreadingModel.Both)]
  [ContractVersion(typeof (CallsPhoneContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class PhoneLineConfiguration : IPhoneLineConfiguration
  {
    public extern bool IsVideoCallingEnabled { [MethodImpl] get; }

    public extern IMapView<string, object> ExtendedProperties { [MethodImpl] get; }
  }
}
