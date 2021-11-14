// Decompiled with JetBrains decompiler
// Type: Windows.Storage.IApplicationDataStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Storage
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1444025467, 59459, 17891, 148, 216, 6, 22, 158, 60, 142, 23)]
  [ExclusiveTo(typeof (ApplicationData))]
  internal interface IApplicationDataStatics
  {
    ApplicationData Current { get; }
  }
}
