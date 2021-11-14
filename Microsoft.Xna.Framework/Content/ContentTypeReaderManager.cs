// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.ContentTypeReaderManager
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Security;

namespace Microsoft.Xna.Framework.Content
{
  public sealed class ContentTypeReaderManager
  {
    private ContentReader contentReader;
    private static Dictionary<string, ContentTypeReader> nameToReader = new Dictionary<string, ContentTypeReader>();
    private static Dictionary<Type, ContentTypeReader> targetTypeToReader = new Dictionary<Type, ContentTypeReader>();
    private static Dictionary<Type, ContentTypeReader> readerTypeToReader = new Dictionary<Type, ContentTypeReader>();

    [SuppressMessage("Microsoft.Performance", "CA1810:InitializeReferenceTypeStaticFieldsInline")]
    static ContentTypeReaderManager()
    {
      ContentTypeReader contentTypeReader = (ContentTypeReader) new ObjectReader();
      ContentTypeReaderManager.targetTypeToReader.Add(typeof (object), contentTypeReader);
      ContentTypeReaderManager.readerTypeToReader.Add(typeof (ObjectReader), contentTypeReader);
    }

    private ContentTypeReaderManager(ContentReader contentReader) => this.contentReader = contentReader;

    internal static ContentTypeReader[] ReadTypeManifest(
      int typeCount,
      ContentReader contentReader)
    {
      ContentTypeReader[] contentTypeReaderArray = new ContentTypeReader[typeCount];
      lock (ContentTypeReaderManager.nameToReader)
      {
        List<ContentTypeReader> newTypeReaders = (List<ContentTypeReader>) null;
        try
        {
          for (int index = 0; index < typeCount; ++index)
          {
            ContentTypeReader typeReader = ContentTypeReaderManager.GetTypeReader(contentReader.ReadString(), contentReader, ref newTypeReaders);
            if (contentReader.ReadInt32() != typeReader.TypeVersion)
              throw contentReader.CreateContentLoadException(FrameworkResources.BadXnbTypeVersion, (object) typeReader.TargetType);
            contentTypeReaderArray[index] = typeReader;
          }
          if (newTypeReaders != null)
          {
            ContentTypeReaderManager manager = new ContentTypeReaderManager(contentReader);
            foreach (ContentTypeReader contentTypeReader in newTypeReaders)
              contentTypeReader.Initialize(manager);
          }
        }
        catch
        {
          ContentTypeReaderManager.RollbackAddReaders(newTypeReaders);
          throw;
        }
      }
      return contentTypeReaderArray;
    }

    private static ContentTypeReader GetTypeReader(
      string readerTypeName,
      ContentReader contentReader,
      ref List<ContentTypeReader> newTypeReaders)
    {
      ContentTypeReader reader;
      if (ContentTypeReaderManager.nameToReader.TryGetValue(readerTypeName, out reader) || !ContentTypeReaderManager.InstantiateTypeReader(readerTypeName, contentReader, out reader))
        return reader;
      ContentTypeReaderManager.AddTypeReader(readerTypeName, contentReader, reader);
      if (newTypeReaders == null)
        newTypeReaders = new List<ContentTypeReader>();
      newTypeReaders.Add(reader);
      return reader;
    }

    [SecuritySafeCritical]
    private static bool InstantiateTypeReader(
      string readerTypeName,
      ContentReader contentReader,
      out ContentTypeReader reader)
    {
      try
      {
        Type type = Type.GetType(readerTypeName);
        if (type == null)
        {
          string str1 = typeof (ReflectiveReader<>).FullName + "[[";
          string str2 = "]]";
          if (readerTypeName.StartsWith(str1) && readerTypeName.EndsWith(str2))
          {
            string str3 = readerTypeName.Substring(str1.Length, readerTypeName.Length - str1.Length - str2.Length);
            throw contentReader.CreateContentLoadException(FrameworkResources.ReflectiveReaderTypeNotFound, (object) str3);
          }
          throw contentReader.CreateContentLoadException(FrameworkResources.TypeReaderNotFound, (object) readerTypeName);
        }
        if (ContentTypeReaderManager.readerTypeToReader.TryGetValue(type, out reader))
        {
          ContentTypeReaderManager.nameToReader.Add(readerTypeName, reader);
          return false;
        }
        reader = (ContentTypeReader) Activator.CreateInstance(type);
        return true;
      }
      catch (Exception ex)
      {
        switch (ex)
        {
          case ArgumentException _:
          case TargetInvocationException _:
          case TypeLoadException _:
          case NotSupportedException _:
          case MemberAccessException _:
          case InvalidCastException _:
            throw contentReader.CreateContentLoadException(ex, FrameworkResources.TypeReaderInvalid, (object) readerTypeName);
          default:
            throw;
        }
      }
    }

    private static void AddTypeReader(
      string readerTypeName,
      ContentReader contentReader,
      ContentTypeReader reader)
    {
      Type targetType = reader.TargetType;
      if (targetType != null)
      {
        if (ContentTypeReaderManager.targetTypeToReader.ContainsKey(targetType))
          throw contentReader.CreateContentLoadException(FrameworkResources.TypeReaderDuplicate, (object) readerTypeName, (object) ContentTypeReaderManager.targetTypeToReader[targetType].GetType().AssemblyQualifiedName, (object) targetType);
        ContentTypeReaderManager.targetTypeToReader.Add(targetType, reader);
      }
      ContentTypeReaderManager.readerTypeToReader.Add(reader.GetType(), reader);
      ContentTypeReaderManager.nameToReader.Add(readerTypeName, reader);
    }

    private static void RollbackAddReaders(List<ContentTypeReader> newTypeReaders)
    {
      if (newTypeReaders == null)
        return;
      foreach (ContentTypeReader newTypeReader in newTypeReaders)
      {
        ContentTypeReaderManager.RollbackAddReader<string>(ContentTypeReaderManager.nameToReader, newTypeReader);
        ContentTypeReaderManager.RollbackAddReader<Type>(ContentTypeReaderManager.targetTypeToReader, newTypeReader);
        ContentTypeReaderManager.RollbackAddReader<Type>(ContentTypeReaderManager.readerTypeToReader, newTypeReader);
      }
    }

    private static void RollbackAddReader<T>(
      Dictionary<T, ContentTypeReader> dictionary,
      ContentTypeReader reader)
    {
      IEnumerator<KeyValuePair<T, ContentTypeReader>> enumerator = (IEnumerator<KeyValuePair<T, ContentTypeReader>>) dictionary.GetEnumerator();
      while (enumerator.MoveNext())
      {
        KeyValuePair<T, ContentTypeReader> current = enumerator.Current;
        if (current.Value == reader)
        {
          Dictionary<T, ContentTypeReader> dictionary1 = dictionary;
          current = enumerator.Current;
          T key = current.Key;
          dictionary1.Remove(key);
          enumerator = (IEnumerator<KeyValuePair<T, ContentTypeReader>>) dictionary.GetEnumerator();
        }
      }
    }

    internal static ContentTypeReader GetTypeReader(
      Type targetType,
      ContentReader contentReader)
    {
      if (targetType == null)
        throw new ArgumentNullException(nameof (targetType));
      ContentTypeReader contentTypeReader;
      lock (ContentTypeReaderManager.nameToReader)
      {
        if (!ContentTypeReaderManager.targetTypeToReader.TryGetValue(targetType, out contentTypeReader))
          throw contentReader.CreateContentLoadException(FrameworkResources.TypeReaderNotRegistered, (object) targetType);
      }
      return contentTypeReader;
    }

    [SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic")]
    public ContentTypeReader GetTypeReader(Type targetType) => ContentTypeReaderManager.GetTypeReader(targetType, this.contentReader);

    internal static bool ContainsTypeReader(Type targetType)
    {
      lock (ContentTypeReaderManager.nameToReader)
        return ContentTypeReaderManager.targetTypeToReader.ContainsKey(targetType);
    }
  }
}
