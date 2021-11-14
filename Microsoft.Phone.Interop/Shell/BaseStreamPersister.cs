// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Shell.BaseStreamPersister
// Assembly: Microsoft.Phone.Interop, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 907B9E60-8AC1-4A62-B7D2-210EC5A188A9
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI93EA~1.DLL

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;

namespace Microsoft.Phone.Shell
{
  internal static class BaseStreamPersister
  {
    internal static byte[] Serialize(
      IDictionary<string, object> dictionary,
      IEnumerable<Type> knownTypes)
    {
      if (!(dictionary is Dictionary<string, object>))
        return (byte[]) null;
      MemoryStream memoryStream = new MemoryStream();
      new DataContractSerializer(typeof (Dictionary<string, object>), knownTypes).WriteObject((Stream) memoryStream, (object) dictionary);
      return memoryStream.ToArray();
    }

    internal static byte[] Serialize(
      IDictionary<string, byte[]> dictionary,
      IEnumerable<Type> knownTypes)
    {
      if (!(dictionary is Dictionary<string, byte[]>))
        return (byte[]) null;
      MemoryStream memoryStream = new MemoryStream();
      new DataContractSerializer(typeof (Dictionary<string, byte[]>), knownTypes).WriteObject((Stream) memoryStream, (object) dictionary);
      return memoryStream.ToArray();
    }

    internal static byte[] Serialize(List<string> list)
    {
      if (list == null)
        return (byte[]) null;
      MemoryStream memoryStream = new MemoryStream();
      new DataContractSerializer(typeof (List<string>)).WriteObject((Stream) memoryStream, (object) list);
      return memoryStream.ToArray();
    }

    internal static void Deserialize(
      byte[] blob,
      IEnumerable<Type> knownTypes,
      ref IDictionary<string, object> dictionary)
    {
      if (blob.Length != 0)
      {
        Stream stream = (Stream) new MemoryStream(blob);
        DataContractSerializer contractSerializer = new DataContractSerializer(typeof (Dictionary<string, object>), knownTypes);
        dictionary = (IDictionary<string, object>) contractSerializer.ReadObject(stream);
      }
      else
        dictionary = (IDictionary<string, object>) new Dictionary<string, object>();
    }

    internal static void Deserialize(
      byte[] blob,
      IEnumerable<Type> knownTypes,
      ref Dictionary<string, byte[]> dictionary)
    {
      if (blob.Length != 0)
      {
        Stream stream = (Stream) new MemoryStream(blob);
        DataContractSerializer contractSerializer = new DataContractSerializer(typeof (Dictionary<string, byte[]>), knownTypes);
        dictionary = (Dictionary<string, byte[]>) contractSerializer.ReadObject(stream);
      }
      else
        dictionary = new Dictionary<string, byte[]>();
    }

    internal static void Deserialize(byte[] blob, ref List<string> list)
    {
      if (blob.Length == 0)
        return;
      Stream stream = (Stream) new MemoryStream(blob);
      DataContractSerializer contractSerializer = new DataContractSerializer(typeof (List<string>));
      list = (List<string>) contractSerializer.ReadObject(stream);
    }
  }
}
