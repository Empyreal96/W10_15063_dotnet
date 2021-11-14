// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.StreamPersister
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Windows.Navigation;

namespace Microsoft.Phone.Shell
{
  internal static class StreamPersister
  {
    internal static byte[] Serialize(IEnumerable<IJournalEntry> list, IEnumerable<Type> knownTypes)
    {
      if (list == null || list.Count<IJournalEntry>() == 0)
        return (byte[]) null;
      List<JournalEntryData> journalEntryDataList = new List<JournalEntryData>();
      foreach (IJournalEntry journalEntry in list)
        journalEntryDataList.Add(journalEntry.JournalEntryData);
      MemoryStream memoryStream = new MemoryStream();
      new DataContractSerializer(typeof (List<JournalEntryData>), knownTypes).WriteObject((Stream) memoryStream, (object) journalEntryDataList);
      return memoryStream.ToArray();
    }

    internal static List<JournalEntryData> Deserialize(
      byte[] blob,
      IEnumerable<Type> knownTypes)
    {
      if (blob == null)
        return (List<JournalEntryData>) null;
      MemoryStream memoryStream = new MemoryStream(blob);
      return (List<JournalEntryData>) new DataContractSerializer(typeof (List<JournalEntryData>), knownTypes).ReadObject((Stream) memoryStream);
    }

    internal static byte[] Serialize(
      IDictionary<string, object> dictionary,
      IEnumerable<Type> knownTypes)
    {
      return BaseStreamPersister.Serialize(dictionary, knownTypes);
    }

    internal static byte[] Serialize(List<string> list) => BaseStreamPersister.Serialize(list);

    internal static void Deserialize(
      byte[] blob,
      IEnumerable<Type> knownTypes,
      ref IDictionary<string, object> dictionary)
    {
      BaseStreamPersister.Deserialize(blob, knownTypes, ref dictionary);
    }

    internal static void Deserialize(byte[] blob, ref List<string> list) => BaseStreamPersister.Deserialize(blob, ref list);
  }
}
