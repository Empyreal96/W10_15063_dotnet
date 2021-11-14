// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.CryptographicBuffer
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography
{
  [Static(typeof (ICryptographicBufferStatics), 65536, "Windows.Foundation.UniversalApiContract")]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  [DualApiPartition(version = 100794368)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  public static class CryptographicBuffer
  {
    [MethodImpl]
    public static extern bool Compare(IBuffer object1, IBuffer object2);

    [MethodImpl]
    public static extern IBuffer GenerateRandom(uint length);

    [MethodImpl]
    public static extern uint GenerateRandomNumber();

    [MethodImpl]
    public static extern IBuffer CreateFromByteArray(byte[] value);

    [MethodImpl]
    public static extern void CopyToByteArray(IBuffer buffer, out byte[] value);

    [MethodImpl]
    public static extern IBuffer DecodeFromHexString(string value);

    [MethodImpl]
    public static extern string EncodeToHexString(IBuffer buffer);

    [MethodImpl]
    public static extern IBuffer DecodeFromBase64String(string value);

    [MethodImpl]
    public static extern string EncodeToBase64String(IBuffer buffer);

    [MethodImpl]
    public static extern IBuffer ConvertStringToBinary(
      string value,
      BinaryStringEncoding encoding);

    [MethodImpl]
    public static extern string ConvertBinaryToString(BinaryStringEncoding encoding, IBuffer buffer);
  }
}
