// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Media.ElementaryStreams.TransportStreamDemux
// Assembly: Microsoft.Phone.Media.ElementaryStreams, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: C4AB28B9-B09C-47FC-B326-6B155141A87A
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIFD1A~1.DLL

using System;
using System.Collections.Generic;

namespace Microsoft.Phone.Media.ElementaryStreams
{
  public class TransportStreamDemux
  {
    public static TransportStreamPacketPayloadType ParsePacket(
      int offset,
      byte[] packetBuffer,
      BitExtractor bitExtractor,
      IDictionary<uint, TransportStreamProgram> programs,
      out uint pid,
      out TransportStreamProgram program,
      out uint streamOffset,
      out uint streamCount)
    {
      TransportStreamPacketPayloadType packetPayloadType = TransportStreamPacketPayloadType.None;
      pid = 0U;
      program = (TransportStreamProgram) null;
      streamOffset = 0U;
      streamCount = 0U;
      if (packetBuffer[offset] != (byte) 71)
        throw new TransportStreamDemuxException("Sync Byte not found");
      bitExtractor.Initialize(packetBuffer, offset + 1);
      int num1 = (int) bitExtractor.ReadUBits(1);
      uint num2 = bitExtractor.ReadUBits(1);
      int num3 = (int) bitExtractor.ReadUBits(1);
      pid = bitExtractor.ReadUBits(13);
      int num4 = (int) bitExtractor.ReadUBits(2);
      uint num5 = bitExtractor.ReadUBits(2);
      int num6 = (int) bitExtractor.ReadUBits(4);
      uint num7 = 4;
      if (num5 == 2U || num5 == 3U)
      {
        int num8 = bitExtractor.ReadBits(8);
        bitExtractor.SkipBits(num8 * 8);
        num7 += (uint) (num8 + 1);
      }
      uint num9;
      if (num5 == 1U || num5 == 3U)
      {
        if (pid == 0U)
        {
          bitExtractor.SkipBits(8);
          num9 = num7 + 1U;
          if (num2 != 1U)
            throw new NotImplementedException("ProgramAssociationTable spanning multiple packets");
          packetPayloadType = TransportStreamPacketPayloadType.ProgramAssociationTable;
        }
        else if (programs != null && programs.TryGetValue(pid, out program))
        {
          bitExtractor.SkipBits(8);
          num9 = num7 + 1U;
          if (num2 != 1U)
            throw new NotImplementedException("ProgramMapTable spanning multiple packets");
          packetPayloadType = TransportStreamPacketPayloadType.ProgramMapTable;
        }
        else
        {
          packetPayloadType = TransportStreamPacketPayloadType.Stream;
          streamOffset = (uint) ((ulong) offset + (ulong) num7);
          streamCount = 188U - num7;
        }
      }
      return packetPayloadType;
    }

    public static void ParseProgramAssociationTable(
      BitExtractor bitExtractor,
      ref bool parsedProgramAssociationTable,
      ref IDictionary<uint, TransportStreamProgram> programs)
    {
      if (parsedProgramAssociationTable)
        return;
      parsedProgramAssociationTable = true;
      bitExtractor.SkipBits(12);
      int num1 = (int) bitExtractor.ReadUBits(12);
      bitExtractor.SkipBits(40);
      int num2 = (int) ((uint) (num1 - 5) / 4U) - 1;
      for (int index = 0; index < num2; ++index)
      {
        uint programNumber = bitExtractor.ReadUBits(16);
        bitExtractor.SkipBits(3);
        if (programNumber != 0U)
        {
          uint num3 = bitExtractor.ReadUBits(13);
          if (programs == null)
            programs = (IDictionary<uint, TransportStreamProgram>) new Dictionary<uint, TransportStreamProgram>();
          IDictionary<uint, TransportStreamProgram> dictionary = programs;
          int num4 = (int) num3;
          TransportStreamProgram transportStreamProgram = new TransportStreamProgram((uint) num4, programNumber);
          dictionary[(uint) num4] = transportStreamProgram;
        }
        else
          bitExtractor.SkipBits(13);
      }
    }

    public static void ParseProgramMapTable(
      TransportStreamProgram program,
      BitExtractor bitExtractor,
      AddNewStreamHandler AddNewStream)
    {
      if (program.ParsedPmt)
        return;
      program.ParsedPmt = true;
      bitExtractor.SkipBits(12);
      uint num1 = bitExtractor.ReadUBits(12);
      bitExtractor.SkipBits(60);
      uint num2 = bitExtractor.ReadUBits(12);
      bitExtractor.SkipBits((int) num2 * 8);
      uint num3 = num1 - (9U + num2);
      while (num3 >= 9U)
      {
        uint streamType = bitExtractor.ReadUBits(8);
        bitExtractor.SkipBits(3);
        uint elementaryPid = bitExtractor.ReadUBits(13);
        bitExtractor.SkipBits(4);
        uint num4 = bitExtractor.ReadUBits(12);
        bitExtractor.SkipBits((int) num4 * 8);
        num3 -= 5U + num4;
        AddNewStream(streamType, elementaryPid);
      }
    }
  }
}
