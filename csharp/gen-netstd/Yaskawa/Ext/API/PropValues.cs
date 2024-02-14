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
using Thrift.Protocol.Entities;
using Thrift.Protocol.Utilities;
using Thrift.Transport;
using Thrift.Transport.Client;
using Thrift.Transport.Server;
using Thrift.Processor;


#pragma warning disable IDE0079  // remove unnecessary pragmas
#pragma warning disable IDE0017  // object init can be simplified
#pragma warning disable IDE0028  // collection init can be simplified
#pragma warning disable IDE1006  // parts of the code use IDL spelling
#pragma warning disable CA1822   // empty DeepCopy() methods still non-static
#pragma warning disable IDE0083  // pattern matching "that is not SomeType" requires net5.0 but we still support earlier versions

namespace Yaskawa.Ext.API
{

  public partial class PropValues : TBase
  {

    public string ItemID { get; set; }

    public Dictionary<string, global::Yaskawa.Ext.API.Any> Props { get; set; }

    public PropValues()
    {
    }

    public PropValues(string itemID, Dictionary<string, global::Yaskawa.Ext.API.Any> props) : this()
    {
      this.ItemID = itemID;
      this.Props = props;
    }

    public PropValues DeepCopy()
    {
      var tmp158 = new PropValues();
      if((ItemID != null))
      {
        tmp158.ItemID = this.ItemID;
      }
      if((Props != null))
      {
        tmp158.Props = this.Props.DeepCopy();
      }
      return tmp158;
    }

    public async global::System.Threading.Tasks.Task ReadAsync(TProtocol iprot, CancellationToken cancellationToken)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        bool isset_itemID = false;
        bool isset_props = false;
        TField field;
        await iprot.ReadStructBeginAsync(cancellationToken);
        while (true)
        {
          field = await iprot.ReadFieldBeginAsync(cancellationToken);
          if (field.Type == TType.Stop)
          {
            break;
          }

          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String)
              {
                ItemID = await iprot.ReadStringAsync(cancellationToken);
                isset_itemID = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            case 2:
              if (field.Type == TType.Map)
              {
                {
                  var _map159 = await iprot.ReadMapBeginAsync(cancellationToken);
                  Props = new Dictionary<string, global::Yaskawa.Ext.API.Any>(_map159.Count);
                  for(int _i160 = 0; _i160 < _map159.Count; ++_i160)
                  {
                    string _key161;
                    global::Yaskawa.Ext.API.Any _val162;
                    _key161 = await iprot.ReadStringAsync(cancellationToken);
                    _val162 = new global::Yaskawa.Ext.API.Any();
                    await _val162.ReadAsync(iprot, cancellationToken);
                    Props[_key161] = _val162;
                  }
                  await iprot.ReadMapEndAsync(cancellationToken);
                }
                isset_props = true;
              }
              else
              {
                await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              }
              break;
            default: 
              await TProtocolUtil.SkipAsync(iprot, field.Type, cancellationToken);
              break;
          }

          await iprot.ReadFieldEndAsync(cancellationToken);
        }

        await iprot.ReadStructEndAsync(cancellationToken);
        if (!isset_itemID)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
        if (!isset_props)
        {
          throw new TProtocolException(TProtocolException.INVALID_DATA);
        }
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public async global::System.Threading.Tasks.Task WriteAsync(TProtocol oprot, CancellationToken cancellationToken)
    {
      oprot.IncrementRecursionDepth();
      try
      {
        var tmp163 = new TStruct("PropValues");
        await oprot.WriteStructBeginAsync(tmp163, cancellationToken);
        var tmp164 = new TField();
        if((ItemID != null))
        {
          tmp164.Name = "itemID";
          tmp164.Type = TType.String;
          tmp164.ID = 1;
          await oprot.WriteFieldBeginAsync(tmp164, cancellationToken);
          await oprot.WriteStringAsync(ItemID, cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        if((Props != null))
        {
          tmp164.Name = "props";
          tmp164.Type = TType.Map;
          tmp164.ID = 2;
          await oprot.WriteFieldBeginAsync(tmp164, cancellationToken);
          await oprot.WriteMapBeginAsync(new TMap(TType.String, TType.Struct, Props.Count), cancellationToken);
          foreach (string _iter165 in Props.Keys)
          {
            await oprot.WriteStringAsync(_iter165, cancellationToken);
            await Props[_iter165].WriteAsync(oprot, cancellationToken);
          }
          await oprot.WriteMapEndAsync(cancellationToken);
          await oprot.WriteFieldEndAsync(cancellationToken);
        }
        await oprot.WriteFieldStopAsync(cancellationToken);
        await oprot.WriteStructEndAsync(cancellationToken);
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override bool Equals(object that)
    {
      if (!(that is PropValues other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return global::System.Object.Equals(ItemID, other.ItemID)
        && TCollections.Equals(Props, other.Props);
    }

    public override int GetHashCode() {
      int hashcode = 157;
      unchecked {
        if((ItemID != null))
        {
          hashcode = (hashcode * 397) + ItemID.GetHashCode();
        }
        if((Props != null))
        {
          hashcode = (hashcode * 397) + TCollections.GetHashCode(Props);
        }
      }
      return hashcode;
    }

    public override string ToString()
    {
      var tmp166 = new StringBuilder("PropValues(");
      if((ItemID != null))
      {
        tmp166.Append(", ItemID: ");
        ItemID.ToString(tmp166);
      }
      if((Props != null))
      {
        tmp166.Append(", Props: ");
        Props.ToString(tmp166);
      }
      tmp166.Append(')');
      return tmp166.ToString();
    }
  }

}
