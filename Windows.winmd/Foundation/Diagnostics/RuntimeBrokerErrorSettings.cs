// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.RuntimeBrokerErrorSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Activatable(65536, "Windows.Foundation.UniversalApiContract")]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [Threading(ThreadingModel.Both)]
  public sealed class RuntimeBrokerErrorSettings : IErrorReportingSettings
  {
    [MethodImpl]
    public extern RuntimeBrokerErrorSettings();

    [MethodImpl]
    public extern void SetErrorOptions(ErrorOptions value);

    [MethodImpl]
    public extern ErrorOptions GetErrorOptions();
  }
}
