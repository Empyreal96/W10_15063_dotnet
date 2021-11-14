// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.IErrorReportingSettings
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(372676498, 45118, 19361, 139, 184, 210, 143, 74, 180, 210, 192)]
  public interface IErrorReportingSettings
  {
    void SetErrorOptions(ErrorOptions value);

    ErrorOptions GetErrorOptions();
  }
}
