// Decompiled with JetBrains decompiler
// Type: PhoneInternal.CorePlat.Diagnostics.IDiagnosticsControllerFactory
// Assembly: PhoneInternal.CorePlat, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 567D0613-1791-46D6-BCA3-107C5D9EF3FD
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\PhoneInternal.CorePlat.winmd

using Windows.Foundation.Metadata;

namespace PhoneInternal.CorePlat.Diagnostics
{
  [Guid(711355650, 210, 17143, 135, 240, 1, 32, 47, 119, 62, 30)]
  [Version(100859904)]
  [ExclusiveTo(typeof (DiagnosticsController))]
  internal interface IDiagnosticsControllerFactory
  {
    DiagnosticsController CreateDiagnosticsController(string appName);
  }
}
