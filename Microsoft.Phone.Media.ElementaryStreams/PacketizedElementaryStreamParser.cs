// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Media.ElementaryStreams.PacketizedElementaryStreamParser
// Assembly: Microsoft.Phone.Media.ElementaryStreams, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: C4AB28B9-B09C-47FC-B326-6B155141A87A
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFD1A~1.DLL

namespace Microsoft.Phone.Media.ElementaryStreams
{
  public class PacketizedElementaryStreamParser
  {
    public static int ParseHeader(
      byte[] data,
      int offset,
      uint count,
      BitExtractor bitstream,
      ref bool newStream,
      ref uint skippedBytes,
      ref uint streamID,
      ref uint markerCount,
      ref uint markerBuffer,
      out int bytesToRead,
      out long presentationTimestamp,
      out long decoderTimestamp)
    {
      bytesToRead = 0;
      presentationTimestamp = 0L;
      decoderTimestamp = 0L;
      int num1 = 0;
      while ((long) num1 < (long) (count - 2U) && (data[offset + num1] != (byte) 0 || data[offset + num1 + 1] != (byte) 0 || data[offset + num1 + 2] != (byte) 1))
        ++num1;
      if ((long) count - (long) num1 < 10L)
        return 0;
      if (num1 > 0)
      {
        if (!newStream)
          throw new PacketizedElementaryStreamParserException("Sync bits not found");
        if (data[offset + num1] != (byte) 0)
          ++num1;
        if (data[offset + num1] != (byte) 0)
          ++num1;
        bytesToRead = 0;
        skippedBytes += (uint) num1;
        return num1;
      }
      if (newStream)
        newStream = false;
      bitstream.Initialize(data, offset + 3);
      uint num2 = bitstream.ReadUBits(8);
      if (streamID == 0U)
        streamID = num2;
      uint num3 = bitstream.ReadUBits(16);
      if (bitstream.ReadUBits(2) != 2U)
      {
        if (num3 > 0U)
        {
          bytesToRead = (int) num3;
        }
        else
        {
          bytesToRead = 2147418112;
          markerCount = 0U;
          markerBuffer = 0U;
        }
        return 6;
      }
      bitstream.SkipBits(6);
      uint num4 = bitstream.ReadUBits(1);
      uint num5 = bitstream.ReadUBits(1);
      bitstream.SkipBits(6);
      uint num6 = bitstream.ReadUBits(8);
      if (count < 9U + num6)
        return 0;
      if (num4 != 0U)
      {
        switch (bitstream.ReadUBits(4))
        {
          case 2:
          case 3:
            ulong num7 = bitstream.ReadBitsULong(3) << 30;
            bitstream.SkipBits(1);
            ulong num8 = num7 | bitstream.ReadBitsULong(15) << 15;
            bitstream.SkipBits(1);
            ulong num9 = num8 | bitstream.ReadBitsULong(15);
            bitstream.SkipBits(1);
            presentationTimestamp = (long) num9;
            if (num5 != 0U)
            {
              if (bitstream.ReadUBits(4) != 1U)
                throw new PacketizedElementaryStreamParserException("Invalid DTS prefix");
              ulong num10 = bitstream.ReadBitsULong(3) << 30;
              bitstream.SkipBits(1);
              ulong num11 = num10 | bitstream.ReadBitsULong(15) << 15;
              bitstream.SkipBits(1);
              ulong num12 = num11 | bitstream.ReadBitsULong(15);
              bitstream.SkipBits(1);
              decoderTimestamp = (long) num12;
              break;
            }
            break;
          default:
            throw new PacketizedElementaryStreamParserException("Invalid PTS prefix");
        }
      }
      else if (num5 != 0U)
        throw new PacketizedElementaryStreamParserException("DTS without PTS present");
      if (num3 > 0U)
      {
        bytesToRead = (int) num3 - (int) num6 - 3;
      }
      else
      {
        bytesToRead = 2147418112;
        markerCount = 0U;
        markerBuffer = 0U;
      }
      return 9 + (int) num6;
    }
  }
}
