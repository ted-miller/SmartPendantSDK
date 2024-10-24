/**
 * <auto-generated>
 * Autogenerated by Thrift Compiler (0.17.0)
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 * </auto-generated>
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Yaskawa.Ext.API
{
  public static class extensionExtensions
  {
    public static bool Equals(this Dictionary<int, string> instance, object that)
    {
      if (!(that is Dictionary<int, string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<int, string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<int, string> DeepCopy(this Dictionary<int, string> source)
    {
      if (source == null)
        return null;

      var tmp4264 = new Dictionary<int, string>(source.Count);
      foreach (var pair in source)
        tmp4264.Add(pair.Key, (pair.Value != null) ? pair.Value : null);
      return tmp4264;
    }


    public static bool Equals(this Dictionary<string, global::Yaskawa.Ext.API.Any> instance, object that)
    {
      if (!(that is Dictionary<string, global::Yaskawa.Ext.API.Any> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<string, global::Yaskawa.Ext.API.Any> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<string, global::Yaskawa.Ext.API.Any> DeepCopy(this Dictionary<string, global::Yaskawa.Ext.API.Any> source)
    {
      if (source == null)
        return null;

      var tmp4265 = new Dictionary<string, global::Yaskawa.Ext.API.Any>(source.Count);
      foreach (var pair in source)
        tmp4265.Add((pair.Key != null) ? pair.Key : null, (pair.Value != null) ? pair.Value.DeepCopy() : null);
      return tmp4265;
    }


    public static bool Equals(this Dictionary<string, global::Yaskawa.Ext.API.Data> instance, object that)
    {
      if (!(that is Dictionary<string, global::Yaskawa.Ext.API.Data> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this Dictionary<string, global::Yaskawa.Ext.API.Data> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static Dictionary<string, global::Yaskawa.Ext.API.Data> DeepCopy(this Dictionary<string, global::Yaskawa.Ext.API.Data> source)
    {
      if (source == null)
        return null;

      var tmp4266 = new Dictionary<string, global::Yaskawa.Ext.API.Data>(source.Count);
      foreach (var pair in source)
        tmp4266.Add((pair.Key != null) ? pair.Key : null, (pair.Value != null) ? pair.Value.DeepCopy() : null);
      return tmp4266;
    }


    public static bool Equals(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> instance, object that)
    {
      if (!(that is HashSet<global::Yaskawa.Ext.API.ControllerEventType> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<global::Yaskawa.Ext.API.ControllerEventType> DeepCopy(this HashSet<global::Yaskawa.Ext.API.ControllerEventType> source)
    {
      if (source == null)
        return null;

      var tmp4267 = new HashSet<global::Yaskawa.Ext.API.ControllerEventType>(source.Count);
      foreach (var elem in source)
        tmp4267.Add(elem);
      return tmp4267;
    }


    public static bool Equals(this HashSet<global::Yaskawa.Ext.API.PendantEventType> instance, object that)
    {
      if (!(that is HashSet<global::Yaskawa.Ext.API.PendantEventType> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<global::Yaskawa.Ext.API.PendantEventType> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<global::Yaskawa.Ext.API.PendantEventType> DeepCopy(this HashSet<global::Yaskawa.Ext.API.PendantEventType> source)
    {
      if (source == null)
        return null;

      var tmp4268 = new HashSet<global::Yaskawa.Ext.API.PendantEventType>(source.Count);
      foreach (var elem in source)
        tmp4268.Add(elem);
      return tmp4268;
    }


    public static bool Equals(this HashSet<string> instance, object that)
    {
      if (!(that is HashSet<string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this HashSet<string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static HashSet<string> DeepCopy(this HashSet<string> source)
    {
      if (source == null)
        return null;

      var tmp4269 = new HashSet<string>(source.Count);
      foreach (var elem in source)
        tmp4269.Add((elem != null) ? elem : null);
      return tmp4269;
    }


    public static bool Equals(this List<List<double>> instance, object that)
    {
      if (!(that is List<List<double>> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<List<double>> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<List<double>> DeepCopy(this List<List<double>> source)
    {
      if (source == null)
        return null;

      var tmp4270 = new List<List<double>>(source.Count);
      foreach (var elem in source)
        tmp4270.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4270;
    }


    public static bool Equals(this List<double> instance, object that)
    {
      if (!(that is List<double> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<double> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<double> DeepCopy(this List<double> source)
    {
      if (source == null)
        return null;

      var tmp4271 = new List<double>(source.Count);
      foreach (var elem in source)
        tmp4271.Add(elem);
      return tmp4271;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.Any> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.Any> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.Any> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.Any> DeepCopy(this List<global::Yaskawa.Ext.API.Any> source)
    {
      if (source == null)
        return null;

      var tmp4272 = new List<global::Yaskawa.Ext.API.Any>(source.Count);
      foreach (var elem in source)
        tmp4272.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4272;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.ControlGroup> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.ControlGroup> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.ControlGroup> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.ControlGroup> DeepCopy(this List<global::Yaskawa.Ext.API.ControlGroup> source)
    {
      if (source == null)
        return null;

      var tmp4273 = new List<global::Yaskawa.Ext.API.ControlGroup>(source.Count);
      foreach (var elem in source)
        tmp4273.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4273;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.ControllerEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.ControllerEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.ControllerEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.ControllerEvent> DeepCopy(this List<global::Yaskawa.Ext.API.ControllerEvent> source)
    {
      if (source == null)
        return null;

      var tmp4274 = new List<global::Yaskawa.Ext.API.ControllerEvent>(source.Count);
      foreach (var elem in source)
        tmp4274.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4274;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.DataPoint> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.DataPoint> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.DataPoint> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.DataPoint> DeepCopy(this List<global::Yaskawa.Ext.API.DataPoint> source)
    {
      if (source == null)
        return null;

      var tmp4275 = new List<global::Yaskawa.Ext.API.DataPoint>(source.Count);
      foreach (var elem in source)
        tmp4275.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4275;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.JointType> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.JointType> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.JointType> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.JointType> DeepCopy(this List<global::Yaskawa.Ext.API.JointType> source)
    {
      if (source == null)
        return null;

      var tmp4276 = new List<global::Yaskawa.Ext.API.JointType>(source.Count);
      foreach (var elem in source)
        tmp4276.Add(elem);
      return tmp4276;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.LoggingEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.LoggingEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.LoggingEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.LoggingEvent> DeepCopy(this List<global::Yaskawa.Ext.API.LoggingEvent> source)
    {
      if (source == null)
        return null;

      var tmp4277 = new List<global::Yaskawa.Ext.API.LoggingEvent>(source.Count);
      foreach (var elem in source)
        tmp4277.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4277;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.PendantEvent> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.PendantEvent> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.PendantEvent> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.PendantEvent> DeepCopy(this List<global::Yaskawa.Ext.API.PendantEvent> source)
    {
      if (source == null)
        return null;

      var tmp4278 = new List<global::Yaskawa.Ext.API.PendantEvent>(source.Count);
      foreach (var elem in source)
        tmp4278.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4278;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.PropValues> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.PropValues> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.PropValues> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.PropValues> DeepCopy(this List<global::Yaskawa.Ext.API.PropValues> source)
    {
      if (source == null)
        return null;

      var tmp4279 = new List<global::Yaskawa.Ext.API.PropValues>(source.Count);
      foreach (var elem in source)
        tmp4279.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4279;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.SimpleControlGroup> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.SimpleControlGroup> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.SimpleControlGroup> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.SimpleControlGroup> DeepCopy(this List<global::Yaskawa.Ext.API.SimpleControlGroup> source)
    {
      if (source == null)
        return null;

      var tmp4280 = new List<global::Yaskawa.Ext.API.SimpleControlGroup>(source.Count);
      foreach (var elem in source)
        tmp4280.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4280;
    }


    public static bool Equals(this List<global::Yaskawa.Ext.API.storageInfo> instance, object that)
    {
      if (!(that is List<global::Yaskawa.Ext.API.storageInfo> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<global::Yaskawa.Ext.API.storageInfo> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<global::Yaskawa.Ext.API.storageInfo> DeepCopy(this List<global::Yaskawa.Ext.API.storageInfo> source)
    {
      if (source == null)
        return null;

      var tmp4281 = new List<global::Yaskawa.Ext.API.storageInfo>(source.Count);
      foreach (var elem in source)
        tmp4281.Add((elem != null) ? elem.DeepCopy() : null);
      return tmp4281;
    }


    public static bool Equals(this List<long> instance, object that)
    {
      if (!(that is List<long> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<long> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<long> DeepCopy(this List<long> source)
    {
      if (source == null)
        return null;

      var tmp4282 = new List<long>(source.Count);
      foreach (var elem in source)
        tmp4282.Add(elem);
      return tmp4282;
    }


    public static bool Equals(this List<string> instance, object that)
    {
      if (!(that is List<string> other)) return false;
      if (ReferenceEquals(instance, other)) return true;

      return TCollections.Equals(instance, other);
    }


    public static int GetHashCode(this List<string> instance)
    {
      return TCollections.GetHashCode(instance);
    }


    public static List<string> DeepCopy(this List<string> source)
    {
      if (source == null)
        return null;

      var tmp4283 = new List<string>(source.Count);
      foreach (var elem in source)
        tmp4283.Add((elem != null) ? elem : null);
      return tmp4283;
    }


  }
}
