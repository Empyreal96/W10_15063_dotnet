// Decompiled with JetBrains decompiler
// Type: Windows.System.IAppDiagnosticInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 262144)]
  [ExclusiveTo(typeof (AppDiagnosticInfo))]
  [Guid(3813189274, 34953, 19619, 190, 7, 213, 255, 255, 95, 8, 4)]
  internal interface IAppDiagnosticInfo
  {
    AppInfo AppInfo { get; }
  }
}
