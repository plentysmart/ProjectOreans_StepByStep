//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace TicketMachine.Interfaces
{
    using System;
    using System.Net;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.IO;
    using System.Collections.Generic;
    using Orleans;
    using System.Reflection;
    using Orleans.Serialization;
    using TicketMachine.Interfaces;
    using System.Collections;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class EventFactory
    {
        

                        public static IEvent GetGrain(long primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IEvent), 51380706, primaryKey));
                        }

                        public static IEvent GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IEvent), 51380706, primaryKey, grainClassNamePrefix));
                        }

                        public static IEvent GetGrain(Guid primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IEvent), 51380706, primaryKey));
                        }

                        public static IEvent GetGrain(Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IEvent), 51380706, primaryKey, grainClassNamePrefix));
                        }

            public static IEvent Cast(IAddressable grainRef)
            {
                
                return EventReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [Orleans.GrainReferenceAttribute("TicketMachine.Interfaces.IEvent")]
        internal class EventReference : Orleans.GrainReference, IEvent, Orleans.IAddressable
        {
            

            public static IEvent Cast(IAddressable grainRef)
            {
                
                return (IEvent) GrainReference.CastInternal(typeof(IEvent), (GrainReference gr) => { return new EventReference(gr);}, grainRef, 51380706);
            }

                protected override int InterfaceId { get { return 51380706; } }

                public override bool IsCompatible(int interfaceId) { return interfaceId == this.InterfaceId; }

                protected override string InterfaceName { get { return "TicketMachine.Interfaces.IEvent"; } }

                protected override string GetMethodName(int interfaceId, int methodId) { return EventMethodInvoker.GetMethodName(interfaceId, methodId); }
            
            protected internal EventReference(GrainReference reference) : 
                    base(reference)
            {
            }
            
            [Orleans.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                EventReference input = ((EventReference)(original));
                return ((EventReference)(GrainReference.CopyGrainReference(input)));
            }
            
            [Orleans.SerializerMethodAttribute()]
            public static void _Serializer(object original, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                EventReference input = ((EventReference)(original));
                GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [Orleans.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return EventReference.Cast(((Orleans.GrainReference)(GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public System.Threading.Tasks.Task Initialize(TicketMachine.Interfaces.EventSettings eventSettings)
            {

                return base.InvokeMethodAsync<object>(-1727646359, new object[] {eventSettings}, TimeSpan.Zero );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [Orleans.MethodInvokerAttribute("TicketMachine.Interfaces.IEvent", 51380706)]
    internal class EventMethodInvoker : IGrainMethodInvoker
    {
        
        public int InterfaceId
        {
            get
            {
                return 51380706;
            }
        }
        
        public async System.Threading.Tasks.Task<Object> Invoke(IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {
                if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 51380706:  // IEvent
                        switch (methodId)
                        {
                            case -1727646359: 
                                await ((IEvent)grain).Initialize((EventSettings)arguments[0]);
                              return true;
                            default: 
                                throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 51380706:  // IEvent
                    switch (methodId)
                    {
                        case -1727646359:
                            return "Initialize";
                    case -606142484:
                            return "GetProperties";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [Serializable()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class EventProperties
    {
        

            public Dictionary<string,object> AsDictionary()
            {  
                var retValue = new Dictionary<string,object>();
                return retValue;
            }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class EventManagerFactory
    {
        

                        public static IEventManager GetGrain(long primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IEventManager), 190099299, primaryKey));
                        }

                        public static IEventManager GetGrain(long primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IEventManager), 190099299, primaryKey, grainClassNamePrefix));
                        }

                        public static IEventManager GetGrain(Guid primaryKey)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IEventManager), 190099299, primaryKey));
                        }

                        public static IEventManager GetGrain(Guid primaryKey, string grainClassNamePrefix)
                        {
                            return Cast(GrainFactoryBase.MakeGrainReferenceInternal(typeof(IEventManager), 190099299, primaryKey, grainClassNamePrefix));
                        }

            public static IEventManager Cast(IAddressable grainRef)
            {
                
                return EventManagerReference.Cast(grainRef);
            }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
        [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
        [System.SerializableAttribute()]
        [Orleans.GrainReferenceAttribute("TicketMachine.Interfaces.IEventManager")]
        internal class EventManagerReference : Orleans.GrainReference, IEventManager, Orleans.IAddressable
        {
            

            public static IEventManager Cast(IAddressable grainRef)
            {
                
                return (IEventManager) GrainReference.CastInternal(typeof(IEventManager), (GrainReference gr) => { return new EventManagerReference(gr);}, grainRef, 190099299);
            }

                protected override int InterfaceId { get { return 190099299; } }

                public override bool IsCompatible(int interfaceId) { return interfaceId == this.InterfaceId; }

                protected override string InterfaceName { get { return "TicketMachine.Interfaces.IEventManager"; } }

                protected override string GetMethodName(int interfaceId, int methodId) { return EventManagerMethodInvoker.GetMethodName(interfaceId, methodId); }
            
            protected internal EventManagerReference(GrainReference reference) : 
                    base(reference)
            {
            }
            
            [Orleans.CopierMethodAttribute()]
            public static object _Copier(object original)
            {
                EventManagerReference input = ((EventManagerReference)(original));
                return ((EventManagerReference)(GrainReference.CopyGrainReference(input)));
            }
            
            [Orleans.SerializerMethodAttribute()]
            public static void _Serializer(object original, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
            {
                EventManagerReference input = ((EventManagerReference)(original));
                GrainReference.SerializeGrainReference(input, stream, expected);
            }
            
            [Orleans.DeserializerMethodAttribute()]
            public static object _Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
            {
                return EventManagerReference.Cast(((Orleans.GrainReference)(GrainReference.DeserializeGrainReference(expected, stream))));
            }
            
            public System.Threading.Tasks.Task<System.Guid> AddEvent(TicketMachine.Interfaces.EventSettings eventSettings)
            {

                return base.InvokeMethodAsync<System.Guid>(-766877796, new object[] {eventSettings}, TimeSpan.Zero );
            }
            
            public System.Threading.Tasks.Task<TicketMachine.Interfaces.EventInfo[]> GetAllEvents()
            {

                return base.InvokeMethodAsync<TicketMachine.Interfaces.EventInfo[]>(-1134387456, new object[] {}, TimeSpan.Zero );
            }
            
            public System.Threading.Tasks.Task<TicketMachine.Interfaces.EventInfo> GetEvent(System.Guid id)
            {

                return base.InvokeMethodAsync<TicketMachine.Interfaces.EventInfo>(-209909783, new object[] {id}, TimeSpan.Zero );
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [Orleans.MethodInvokerAttribute("TicketMachine.Interfaces.IEventManager", 190099299)]
    internal class EventManagerMethodInvoker : IGrainMethodInvoker
    {
        
        public int InterfaceId
        {
            get
            {
                return 190099299;
            }
        }
        
        public async System.Threading.Tasks.Task<Object> Invoke(IAddressable grain, int interfaceId, int methodId, object[] arguments)
        {
                if (grain == null) throw new System.ArgumentNullException("grain");
                switch (interfaceId)
                {
                    case 190099299:  // IEventManager
                        switch (methodId)
                        {
                            case -766877796: 
                                return await ((IEventManager)grain).AddEvent((EventSettings)arguments[0]);
                            case -1134387456: 
                                return await ((IEventManager)grain).GetAllEvents();
                            case -209909783: 
                                return await ((IEventManager)grain).GetEvent((Guid)arguments[0]);
                            default: 
                                throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                        }
                    default:
                        throw new System.InvalidCastException("interfaceId="+interfaceId);
                }
        }
        
        public static string GetMethodName(int interfaceId, int methodId)
        {

            switch (interfaceId)
            {
                
                case 190099299:  // IEventManager
                    switch (methodId)
                    {
                        case -766877796:
                            return "AddEvent";
                    case -1134387456:
                            return "GetAllEvents";
                    case -209909783:
                            return "GetEvent";
                    case -606142484:
                            return "GetProperties";
                    
                        default: 
                            throw new NotImplementedException("interfaceId="+interfaceId+",methodId="+methodId);
                    }

                default:
                    throw new System.InvalidCastException("interfaceId="+interfaceId);
            }
        }
    }
    
    [Serializable()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.814.60418")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    public class EventManagerProperties
    {
        

            public Dictionary<string,object> AsDictionary()
            {  
                var retValue = new Dictionary<string,object>();
                return retValue;
            }
    }
    
    [Orleans.RegisterSerializerAttribute()]
    internal class TicketMachine_Interfaces_EventSettingsSerialization
    {
        
        static TicketMachine_Interfaces_EventSettingsSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            TicketMachine.Interfaces.EventSettings input = ((TicketMachine.Interfaces.EventSettings)(original));
            TicketMachine.Interfaces.EventSettings result = new TicketMachine.Interfaces.EventSettings();
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            result.Description = input.Description;
            result.Name = input.Name;
            return result;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            TicketMachine.Interfaces.EventSettings input = ((TicketMachine.Interfaces.EventSettings)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Description, stream, typeof(String));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Name, stream, typeof(String));
        }
        
        public static object Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            TicketMachine.Interfaces.EventSettings result = new TicketMachine.Interfaces.EventSettings();
            result.Description = ((String)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(String), stream)));
            result.Name = ((String)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(String), stream)));
            return result;
        }
        
        public static void Register()
        {
            Orleans.Serialization.SerializationManager.Register(typeof(TicketMachine.Interfaces.EventSettings), DeepCopier, Serializer, Deserializer);
        }
    }
    
    [Orleans.RegisterSerializerAttribute()]
    internal class TicketMachine_Interfaces_EventInfoSerialization
    {
        
        static TicketMachine_Interfaces_EventInfoSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            TicketMachine.Interfaces.EventInfo input = ((TicketMachine.Interfaces.EventInfo)(original));
            TicketMachine.Interfaces.EventInfo result = ((TicketMachine.Interfaces.EventInfo)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(TicketMachine.Interfaces.EventInfo))));
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            result.Description = input.Description;
            result.Id = ((Guid)(Orleans.Serialization.SerializationManager.DeepCopyInner(input.Id)));
            result.Name = input.Name;
            return result;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            TicketMachine.Interfaces.EventInfo input = ((TicketMachine.Interfaces.EventInfo)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Description, stream, typeof(String));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Id, stream, typeof(Guid));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Name, stream, typeof(String));
        }
        
        public static object Deserializer(System.Type expected, Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            TicketMachine.Interfaces.EventInfo result = ((TicketMachine.Interfaces.EventInfo)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(TicketMachine.Interfaces.EventInfo))));
            result.Description = ((String)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(String), stream)));
            result.Id = ((Guid)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(Guid), stream)));
            result.Name = ((String)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(String), stream)));
            return result;
        }
        
        public static void Register()
        {
            Orleans.Serialization.SerializationManager.Register(typeof(TicketMachine.Interfaces.EventInfo), DeepCopier, Serializer, Deserializer);
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
