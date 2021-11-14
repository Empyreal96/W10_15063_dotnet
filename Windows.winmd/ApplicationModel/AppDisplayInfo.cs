// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.AppDisplayInfo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.ApplicationModel
{
  [DualApiPartition(version = 167772160)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class AppDisplayInfo : IAppDisplayInfo
  {
    public extern string DisplayName { [MethodImpl] get; }

    public extern string Description { [MethodImpl] get; }

    [MethodImpl]
    public extern RandomAccessStreamReference GetLogo(Size size);
  }
}
