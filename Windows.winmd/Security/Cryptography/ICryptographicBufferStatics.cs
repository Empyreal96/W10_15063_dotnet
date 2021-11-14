// Decompiled with JetBrains decompiler
// Type: Windows.Security.Cryptography.ICryptographicBufferStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Storage.Streams;

namespace Windows.Security.Cryptography
{
  [ExclusiveTo(typeof (CryptographicBuffer))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(839613986, 15536, 19679, 134, 99, 29, 40, 145, 0, 101, 235)]
  internal interface ICryptographicBufferStatics
  {
    bool Compare(IBuffer object1, IBuffer object2);

    IBuffer GenerateRandom(uint length);

    uint GenerateRandomNumber();

    IBuffer CreateFromByteArray(byte[] value);

    void CopyToByteArray(IBuffer buffer, out byte[] value);

    IBuffer DecodeFromHexString(string value);

    string EncodeToHexString(IBuffer buffer);

    IBuffer DecodeFromBase64String(string value);

    string EncodeToBase64String(IBuffer buffer);

    IBuffer ConvertStringToBinary(string value, BinaryStringEncoding encoding);

    string ConvertBinaryToString(BinaryStringEncoding encoding, IBuffer buffer);
  }
}
