// Decompiled with JetBrains decompiler
// Type: Windows.Management.Core.ApplicationDataManager
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage;

namespace Windows.Management.Core
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Static(typeof (IApplicationDataManagerStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.MTA)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class ApplicationDataManager : IApplicationDataManager
  {
    [MethodImpl]
    public static extern ApplicationData CreateForPackageFamily(
      string packageFamilyName);
  }
}
