// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.ITracingStatusChangedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Guid(1091270417, 65339, 18303, 156, 154, 210, 239, 218, 48, 45, 195)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (TracingStatusChangedEventArgs))]
  internal interface ITracingStatusChangedEventArgs
  {
    bool Enabled { get; }

    CausalityTraceLevel TraceLevel { get; }
  }
}
