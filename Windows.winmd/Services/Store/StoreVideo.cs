// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StoreVideo
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StoreVideo : IStoreVideo
  {
    public extern Uri Uri { [MethodImpl] get; }

    public extern string VideoPurposeTag { [MethodImpl] get; }

    public extern uint Width { [MethodImpl] get; }

    public extern uint Height { [MethodImpl] get; }

    public extern string Caption { [MethodImpl] get; }

    public extern StoreImage PreviewImage { [MethodImpl] get; }
  }
}
