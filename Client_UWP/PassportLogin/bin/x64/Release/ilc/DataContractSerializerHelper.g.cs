using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;

[assembly: global::System.Reflection.AssemblyVersion("4.0.0.0")]



namespace System.Runtime.Serialization.Generated
{
    [global::System.Runtime.CompilerServices.__BlockReflection]
    public static partial class DataContractSerializerHelper
    {
        static void InitDataContracts()
        {
            global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Runtime.Serialization.DataContract> dataContracts = global::System.Runtime.Serialization.DataContract.GetDataContracts();
            PopulateContractDictionary(dataContracts);
        }
        static int[] s_knownContractsLists = new int[] {
              -1,   62,   64,   -1,   58,   59,   62,   -1, }
        ;
        // Count = 307
        static int[] s_xmlDictionaryStrings = new int[] {
                0, // array length: 0
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                5, // array length: 5
                1763, // index: 1763, string: "HelpLink"
                1772, // index: 1772, string: "InnerException"
                1787, // index: 1787, string: "Message"
                1795, // index: 1795, string: "StackTrace"
                1806, // index: 1806, string: "Type"
                5, // array length: 5
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                271, // index: 271, string: "http://schemas.datacontract.org/2004/07/System.ServiceModel"
                4, // array length: 4
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                -1, // string: null
                -1, // string: null
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                4, // array length: 4
                1811, // index: 1811, string: "store"
                1817, // index: 1817, string: "Attachments"
                1829, // index: 1829, string: "Messages"
                904, // index: 904, string: "TestCase"
                4, // array length: 4
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                1811, // index: 1811, string: "store"
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                -1, // string: null
                1, // array length: 1
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                600, // index: 600, string: "Key"
                604, // index: 604, string: "Value"
                2, // array length: 2
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                6, // array length: 6
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                6, // array length: 6
                1838, // index: 1838, string: "_attributes"
                1850, // index: 1850, string: "_category"
                1860, // index: 1860, string: "_description"
                1873, // index: 1873, string: "_id"
                1877, // index: 1877, string: "_label"
                1884, // index: 1884, string: "_strValueType"
                6, // array length: 6
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                4, // array length: 4
                646, // index: 646, string: "None"
                651, // index: 651, string: "Hidden"
                658, // index: 658, string: "Immutable"
                668, // index: 668, string: "Trait"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                -1, // string: null
                1, // array length: 1
                716, // index: 716, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                1898, // index: 1898, string: "key"
                1902, // index: 1902, string: "value"
                2, // array length: 2
                716, // index: 716, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                716, // index: 716, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                3, // array length: 3
                1817, // index: 1817, string: "Attachments"
                1908, // index: 1908, string: "DisplayName"
                1920, // index: 1920, string: "Uri"
                3, // array length: 3
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                1924, // index: 1924, string: "Description"
                1920, // index: 1920, string: "Uri"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                1936, // index: 1936, string: "Category"
                1945, // index: 1945, string: "Text"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                1811, // index: 1811, string: "store"
                1, // array length: 1
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                716, // index: 716, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                1898, // index: 1898, string: "key"
                1902, // index: 1902, string: "value"
                2, // array length: 2
                716, // index: 716, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                716, // index: 716, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                5, // array length: 5
                646, // index: 646, string: "None"
                1000, // index: 1000, string: "Passed"
                1007, // index: 1007, string: "Failed"
                1014, // index: 1014, string: "Skipped"
                1022, // index: 1022, string: "NotFound"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1046, // index: 1046, string: "http://schemas.datacontract.org/2004/07/System"
                2, // array length: 2
                1950, // index: 1950, string: "DateTime"
                1959, // index: 1959, string: "OffsetMinutes"
                2, // array length: 2
                1046, // index: 1046, string: "http://schemas.datacontract.org/2004/07/System"
                1046, // index: 1046, string: "http://schemas.datacontract.org/2004/07/System"
                2, // array length: 2
                -1, // string: null
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                1973, // index: 1973, string: "ExecutedTests"
                1987, // index: 1987, string: "Stats"
                2, // array length: 2
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                600, // index: 600, string: "Key"
                604, // index: 604, string: "Value"
                2, // array length: 2
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                716, // index: 716, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                1898, // index: 1898, string: "key"
                1902, // index: 1902, string: "value"
                2, // array length: 2
                716, // index: 716, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                716, // index: 716, string: "http://schemas.datacontract.org/2004/07/System.Collections.Generic"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                1787, // index: 1787, string: "Message"
                1993, // index: 1993, string: "MessageLevel"
                2, // array length: 2
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                3, // array length: 3
                1458, // index: 1458, string: "Informational"
                1472, // index: 1472, string: "Warning"
                1480, // index: 1480, string: "Error"
                2, // array length: 2
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                2, // array length: 2
                600, // index: 600, string: "Key"
                604, // index: 604, string: "Value"
                2, // array length: 2
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                3, // array length: 3
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                3, // array length: 3
                2006, // index: 2006, string: "Contract"
                2015, // index: 2015, string: "InitParams"
                2026, // index: 2026, string: "TestRunParams"
                3, // array length: 3
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                6, // array length: 6
                1615, // index: 1615, string: "CancelTestRun"
                1629, // index: 1629, string: "InitializeConnection"
                646, // index: 646, string: "None"
                1650, // index: 1650, string: "Shutdown"
                1659, // index: 1659, string: "StartTestRun"
                1672, // index: 1672, string: "StartTestRunWithSources"
                2, // array length: 2
                -1, // string: null
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                1, // array length: 1
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                2, // array length: 2
                2040, // index: 2040, string: "LoadOnlyWellKnownExtensions"
                2068, // index: 2068, string: "PathToAdditionalExtensions"
                2, // array length: 2
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                5, // array length: 5
                -1, // string: null
                -1, // string: null
                504, // index: 504, string: "http://schemas.microsoft.com/2003/10/Serialization/Arrays"
                -1, // string: null
                349, // index: 349, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel"
                1, // array length: 1
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                5, // array length: 5
                2095, // index: 2095, string: "DataCollectorServiceUri"
                2119, // index: 2119, string: "ExecutionContext"
                2136, // index: 2136, string: "Sources"
                2144, // index: 2144, string: "TestRunSettings"
                2160, // index: 2160, string: "Tests"
                5, // array length: 5
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                7, // array length: 7
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                -1, // string: null
                1, // array length: 1
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                7, // array length: 7
                2166, // index: 2166, string: "AreTestCaseLevelEventsRequired"
                2197, // index: 2197, string: "FrequencyOfRunStatsChangeEvent"
                2228, // index: 2228, string: "InIsolation"
                2240, // index: 2240, string: "IsDebug"
                2248, // index: 2248, string: "KeepAlive"
                2258, // index: 2258, string: "RunStatsChangeEventTimeout"
                2285, // index: 2285, string: "TestCaseFilter"
                7, // array length: 7
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106, // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
                1106  // index: 1106, string: "http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core"
        };
        // Count = 18
        static global::MemberEntry[] s_dataMemberLists = new global::MemberEntry[] {
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 646, // None
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 651, // Hidden
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 658, // Immutable
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 668, // Trait
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 646, // None
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1000, // Passed
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1007, // Failed
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1014, // Skipped
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1022, // NotFound
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1458, // Informational
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1472, // Warning
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1480, // Error
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1615, // CancelTestRun
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1629, // InitializeConnection
                    Value = 1,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 646, // None
                    Value = 2,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1650, // Shutdown
                    Value = 3,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1659, // StartTestRun
                    Value = 4,
                }, 
                new global::MemberEntry() {
                    EmitDefaultValue = true,
                    NameIndex = 1672, // StartTestRunWithSources
                    Value = 5,
                }
        };
        static readonly byte[] s_dataContractMap_Hashtable = null;
        // Count=95
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractMapEntry[] s_dataContractMap = new global::DataContractMapEntry[] {
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 0, // 0x0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 16, // 0x10
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 32, // 0x20
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 48, // 0x30
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]" +
                                ", mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 64, // 0x40
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 80, // 0x50
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 96, // 0x60
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 112, // 0x70
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 128, // 0x80
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 144, // 0x90
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 160, // 0xa0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Private.Xml, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd" +
                                "51")),
                    TableIndex = 176, // 0xb0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 192, // 0xc0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], " +
                                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 208, // 0xd0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 224, // 0xe0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]" +
                                "], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 240, // 0xf0
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]], m" +
                                "scorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 256, // 0x100
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 272, // 0x110
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 288, // 0x120
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Nullable`1[[System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089]]," +
                                " mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 304, // 0x130
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 320, // 0x140
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.1.3.0, Culture=neutral, PublicKeyTok" +
                                "en=cc7b13ffcd2ddd51")),
                    TableIndex = 1, // 0x1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 2, // 0x2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 17, // 0x11
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestObject, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 33, // 0x21
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 18, // 0x12
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 49, // 0x31
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, V" +
                                "ersion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 65, // 0x41
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.Obje" +
                                "ctModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 3, // 0x3
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 81, // 0x51
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 34, // 0x22
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 97, // 0x61
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 50, // 0x32
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 113, // 0x71
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 66, // 0x42
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 82, // 0x52
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 129, // 0x81
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 98, // 0x62
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                "on=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 145, // 0x91
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 114, // 0x72
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 130, // 0x82
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 161, // 0xa1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ve" +
                                "rsion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 19, // 0x13
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 19, // 0x13
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.4.0, C" +
                                "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 177, // 0xb1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestRunStats, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0." +
                                "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 193, // 0xc1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 146, // 0x92
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 209, // 0xd1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 225, // 0xe1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 162, // 0xa2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 178, // 0xb2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0," +
                                " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 241, // 0xf1
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.Ob" +
                                "jectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 35, // 0x23
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 35, // 0x23
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                "icKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                "f11d50a3a")),
                    TableIndex = 194, // 0xc2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Exception, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 257, // 0x101
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 210, // 0xd2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 226, // 0xe2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 273, // 0x111
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.PollRequest, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0" +
                                ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 289, // 0x121
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0." +
                                "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 51, // 0x33
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Nullable`1[[Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    TableIndex = 51, // 0x33
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.InitializeConnectionParams, Microsoft.VisualStudio.TestPlatform.Core, V" +
                                "ersion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 305, // 0x131
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.StartTestRunParams, Microsoft.VisualStudio.TestPlatform.Core, Version=1" +
                                "4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 321, // 0x141
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestExecutionContext, Microsoft.VisualStudio.TestPlatform.Core, Version" +
                                "=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 337, // 0x151
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 242, // 0xf2
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 258, // 0x102
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 274, // 0x112
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                "b03f5f7f11d50a3a")),
                    TableIndex = 290, // 0x122
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.ICollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 306, // 0x132
                }, 
                new global::DataContractMapEntry() {
                    UserCodeType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    TableIndex = 322, // 0x142
                }
        };
        static readonly byte[] s_dataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::DataContractEntry[] s_dataContracts = new global::DataContractEntry[] {
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 0, // boolean
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 0, // boolean
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 0, // boolean
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Boolean, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.BooleanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 93, // base64Binary
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 93, // base64Binary
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 93, // base64Binary
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte[], mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ByteArrayDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 106, // char
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 106, // char
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 106, // char
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Char, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.CharDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 111, // dateTime
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 111, // dateTime
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 111, // dateTime
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTime, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DateTimeDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 120, // decimal
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 120, // decimal
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 120, // decimal
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Decimal, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DecimalDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 128, // double
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 128, // double
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 128, // double
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Double, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.DoubleDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 135, // float
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 135, // float
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 135, // float
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Single, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.FloatDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 141, // guid
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 141, // guid
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 141, // guid
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Guid, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.GuidDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 146, // int
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 146, // int
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 146, // int
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.IntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 150, // long
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 150, // long
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 150, // long
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.LongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 155, // anyType
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 155, // anyType
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 155, // anyType
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.ObjectDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 163, // QName
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 163, // QName
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 163, // QName
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Private.Xml, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd" +
                                    "51")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Xml.XmlQualifiedName, System.Private.Xml, Version=4.0.1.0, Culture=neutral, PublicKeyToken=cc7b13ffcd2ddd" +
                                    "51")),
                    },
                    Kind = global::DataContractKind.QNameDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 169, // short
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 169, // short
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 169, // short
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Int16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.ShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 175, // byte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 175, // byte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 175, // byte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.SByte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.SignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 180, // string
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 180, // string
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 180, // string
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.StringDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 187, // duration
                        NamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        StableNameIndex = 187, // duration
                        StableNameNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        TopLevelElementNameIndex = 187, // duration
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.TimeSpan, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.TimeSpanDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 196, // unsignedByte
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 196, // unsignedByte
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 196, // unsignedByte
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Byte, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedByteDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 209, // unsignedInt
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 209, // unsignedInt
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 209, // unsignedInt
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt32, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedIntDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 221, // unsignedLong
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 221, // unsignedLong
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 221, // unsignedLong
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt64, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedLongDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        IsValueType = true,
                        NameIndex = 234, // unsignedShort
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 234, // unsignedShort
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 234, // unsignedShort
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.UInt16, mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")),
                    },
                    Kind = global::DataContractKind.UnsignedShortDataContract,
                }, 
                new global::DataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsBuiltInDataContract = true,
                        NameIndex = 248, // anyURI
                        NamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        StableNameIndex = 248, // anyURI
                        StableNameNamespaceIndex = 8, // http://www.w3.org/2001/XMLSchema
                        TopLevelElementNameIndex = 248, // anyURI
                        TopLevelElementNamespaceIndex = 41, // http://schemas.microsoft.com/2003/10/Serialization/
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Uri, System.Private.Uri, Version=4.0.5.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    Kind = global::DataContractKind.UriDataContract,
                }
        };
        static readonly byte[] s_classDataContracts_Hashtable = null;
        // Count=22
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::ClassDataContractEntry[] s_classDataContracts = new global::ClassDataContractEntry[] {
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 255, // ExceptionDetail
                        NamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        StableNameIndex = 255, // ExceptionDetail
                        StableNameNamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        TopLevelElementNameIndex = 255, // ExceptionDetail
                        TopLevelElementNamespaceIndex = 271, // http://schemas.datacontract.org/2004/07/System.ServiceModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.1.3.0, Culture=neutral, PublicKeyTok" +
                                    "en=cc7b13ffcd2ddd51")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.ServiceModel.ExceptionDetail, System.Private.ServiceModel, Version=4.1.3.0, Culture=neutral, PublicKeyTok" +
                                    "en=cc7b13ffcd2ddd51")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type0.ReadExceptionDetailFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type1.WriteExceptionDetailToXml),
                    ChildElementNamespacesListIndex = 1,
                    ContractNamespacesListIndex = 7,
                    MemberNamesListIndex = 9,
                    MemberNamespacesListIndex = 15,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 437, // TestResult
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 437, // TestResult
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 437, // TestResult
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        KnownDataContractsListIndex = 1,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type5.ReadTestResultFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type6.WriteTestResultToXml),
                    ChildElementNamespacesListIndex = 21,
                    ContractNamespacesListIndex = 26,
                    MemberNamesListIndex = 29,
                    MemberNamespacesListIndex = 34,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 448, // TestObject
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 448, // TestObject
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 448, // TestObject
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestObject, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestObject, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                    "sion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type7.ReadTestObjectFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type8.WriteTestObjectToXml),
                    ChildElementNamespacesListIndex = 39,
                    ContractNamespacesListIndex = 41,
                    MemberNamesListIndex = 43,
                    MemberNamespacesListIndex = 45,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 562, // KeyValueOfTestPropertyanyTypeGfygfmPv
                        NamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 562, // KeyValueOfTestPropertyanyTypeGfygfmPv
                        StableNameNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 562, // KeyValueOfTestPropertyanyTypeGfygfmPv
                        TopLevelElementNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type12.ReadKeyValueOfTestPropertyanyTypeGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type13.WriteKeyValueOfTestPropertyanyTypeGfygfmPvToXml),
                    ChildElementNamespacesListIndex = 47,
                    ContractNamespacesListIndex = 50,
                    MemberNamesListIndex = 52,
                    MemberNamespacesListIndex = 55,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 610, // TestProperty
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 610, // TestProperty
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 610, // TestProperty
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, V" +
                                    "ersion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, V" +
                                    "ersion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type14.ReadTestPropertyFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type15.WriteTestPropertyToXml),
                    ChildElementNamespacesListIndex = 58,
                    ContractNamespacesListIndex = 65,
                    MemberNamesListIndex = 67,
                    MemberNamespacesListIndex = 74,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 674, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                        NamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 674, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                        StableNameNamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 674, // KeyValuePairOfTestPropertyanyTypeGfygfmPv
                        TopLevelElementNamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type16.ReadKeyValuePairOfTestPropertyanyTypeGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type17.WriteKeyValuePairOfTestPropertyanyTypeGfygfmPvToXml),
                    ChildElementNamespacesListIndex = 86,
                    ContractNamespacesListIndex = 89,
                    MemberNamesListIndex = 91,
                    MemberNamespacesListIndex = 94,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 804, // AttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 804, // AttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 804, // AttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                    "Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                    "Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type21.ReadAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type22.WriteAttachmentSetToXml),
                    ChildElementNamespacesListIndex = 97,
                    ContractNamespacesListIndex = 101,
                    MemberNamesListIndex = 103,
                    MemberNamespacesListIndex = 107,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 843, // UriDataAttachment
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 843, // UriDataAttachment
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 843, // UriDataAttachment
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type26.ReadUriDataAttachmentFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type27.WriteUriDataAttachmentToXml),
                    ChildElementNamespacesListIndex = 111,
                    ContractNamespacesListIndex = 114,
                    MemberNamesListIndex = 116,
                    MemberNamespacesListIndex = 119,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 886, // TestResultMessage
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 886, // TestResultMessage
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 886, // TestResultMessage
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                    "el, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type34.ReadTestResultMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type35.WriteTestResultMessageToXml),
                    ChildElementNamespacesListIndex = 122,
                    ContractNamespacesListIndex = 125,
                    MemberNamesListIndex = 127,
                    MemberNamespacesListIndex = 130,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 904, // TestCase
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 904, // TestCase
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 904, // TestCase
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                    "on=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                    "on=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        KnownDataContractsListIndex = 4,
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type39.ReadTestCaseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type40.WriteTestCaseToXml),
                    ChildElementNamespacesListIndex = 133,
                    ContractNamespacesListIndex = 135,
                    MemberNamesListIndex = 138,
                    MemberNamespacesListIndex = 140,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 961, // KeyValuePairOfstringstring
                        NamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 961, // KeyValuePairOfstringstring
                        StableNameNamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 961, // KeyValuePairOfstringstring
                        TopLevelElementNamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type47.ReadKeyValuePairOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type48.WriteKeyValuePairOfstringstringToXml),
                    ChildElementNamespacesListIndex = 142,
                    ContractNamespacesListIndex = 145,
                    MemberNamesListIndex = 147,
                    MemberNamespacesListIndex = 150,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1031, // DateTimeOffset
                        NamespaceIndex = 1046, // http://schemas.datacontract.org/2004/07/System
                        StableNameIndex = 1031, // DateTimeOffset
                        StableNameNamespaceIndex = 1046, // http://schemas.datacontract.org/2004/07/System
                        TopLevelElementNameIndex = 1031, // DateTimeOffset
                        TopLevelElementNamespaceIndex = 1046, // http://schemas.datacontract.org/2004/07/System
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.DateTimeOffset, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a" +
                                    "")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.DateTimeOffsetAdapter, System.Private.DataContractSerialization, Version=4.1.4.0, C" +
                                    "ulture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type49.ReadDateTimeOffsetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type50.WriteDateTimeOffsetToXml),
                    ChildElementNamespacesListIndex = 159,
                    ContractNamespacesListIndex = 162,
                    MemberNamesListIndex = 164,
                    MemberNamespacesListIndex = 167,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1093, // TestRunStats
                        NamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1093, // TestRunStats
                        StableNameNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1093, // TestRunStats
                        TopLevelElementNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestRunStats, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestRunStats, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type51.ReadTestRunStatsFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type52.WriteTestRunStatsToXml),
                    ChildElementNamespacesListIndex = 170,
                    ContractNamespacesListIndex = 173,
                    MemberNamesListIndex = 175,
                    MemberNamespacesListIndex = 178,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1228, // KeyValueOfTestOutcomelongGfygfmPv
                        NamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1228, // KeyValueOfTestOutcomelongGfygfmPv
                        StableNameNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1228, // KeyValueOfTestOutcomelongGfygfmPv
                        TopLevelElementNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type56.ReadKeyValueOfTestOutcomelongGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type57.WriteKeyValueOfTestOutcomelongGfygfmPvToXml),
                    ChildElementNamespacesListIndex = 181,
                    ContractNamespacesListIndex = 184,
                    MemberNamesListIndex = 186,
                    MemberNamespacesListIndex = 189,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1262, // KeyValuePairOfTestOutcomelongGfygfmPv
                        NamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 1262, // KeyValuePairOfTestOutcomelongGfygfmPv
                        StableNameNamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 1262, // KeyValuePairOfTestOutcomelongGfygfmPv
                        TopLevelElementNamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.KeyValuePair`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTo" +
                                    "ken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type58.ReadKeyValuePairOfTestOutcomelongGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type59.WriteKeyValuePairOfTestOutcomelongGfygfmPvToXml),
                    ChildElementNamespacesListIndex = 192,
                    ContractNamespacesListIndex = 195,
                    MemberNamesListIndex = 197,
                    MemberNamespacesListIndex = 200,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1334, // LogMessage
                        NamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1334, // LogMessage
                        StableNameNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1334, // LogMessage
                        TopLevelElementNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0," +
                                    " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type66.ReadLogMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type67.WriteLogMessageToXml),
                    ChildElementNamespacesListIndex = 203,
                    ContractNamespacesListIndex = 206,
                    MemberNamesListIndex = 208,
                    MemberNamespacesListIndex = 211,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsISerializable = true,
                        NameIndex = 1486, // Exception
                        NamespaceIndex = 1046, // http://schemas.datacontract.org/2004/07/System
                        StableNameIndex = 1486, // Exception
                        StableNameNamespaceIndex = 1046, // http://schemas.datacontract.org/2004/07/System
                        TopLevelElementNameIndex = 1486, // Exception
                        TopLevelElementNamespaceIndex = 1046, // http://schemas.datacontract.org/2004/07/System
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Exception, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Exception, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type71.ReadExceptionFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type72.WriteExceptionToXml),
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1526, // KeyValueOfstringstring
                        NamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1526, // KeyValueOfstringstring
                        StableNameNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1526, // KeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Runtime.Serialization.KeyValue`2, System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neut" +
                                    "ral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type79.ReadKeyValueOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type80.WriteKeyValueOfstringstringToXml),
                    ChildElementNamespacesListIndex = 218,
                    ContractNamespacesListIndex = 221,
                    MemberNamesListIndex = 223,
                    MemberNamespacesListIndex = 226,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1549, // PollRequest
                        NamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1549, // PollRequest
                        StableNameNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1549, // PollRequest
                        TopLevelElementNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.PollRequest, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0" +
                                    ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.PollRequest, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0" +
                                    ", Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type81.ReadPollRequestFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type82.WritePollRequestToXml),
                    ChildElementNamespacesListIndex = 229,
                    ContractNamespacesListIndex = 233,
                    MemberNamesListIndex = 235,
                    MemberNamespacesListIndex = 239,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1696, // InitializeConnectionParams
                        NamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1696, // InitializeConnectionParams
                        StableNameNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1696, // InitializeConnectionParams
                        TopLevelElementNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.InitializeConnectionParams, Microsoft.VisualStudio.TestPlatform.Core, V" +
                                    "ersion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.InitializeConnectionParams, Microsoft.VisualStudio.TestPlatform.Core, V" +
                                    "ersion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type83.ReadInitializeConnectionParamsFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type84.WriteInitializeConnectionParamsToXml),
                    ChildElementNamespacesListIndex = 250,
                    ContractNamespacesListIndex = 253,
                    MemberNamesListIndex = 255,
                    MemberNamespacesListIndex = 258,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1723, // StartTestRunParams
                        NamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1723, // StartTestRunParams
                        StableNameNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1723, // StartTestRunParams
                        TopLevelElementNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.StartTestRunParams, Microsoft.VisualStudio.TestPlatform.Core, Version=1" +
                                    "4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.StartTestRunParams, Microsoft.VisualStudio.TestPlatform.Core, Version=1" +
                                    "4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type85.ReadStartTestRunParamsFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type86.WriteStartTestRunParamsToXml),
                    ChildElementNamespacesListIndex = 261,
                    ContractNamespacesListIndex = 267,
                    MemberNamesListIndex = 269,
                    MemberNamespacesListIndex = 275,
                }, 
                new global::ClassDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1742, // TestExecutionContext
                        NamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1742, // TestExecutionContext
                        StableNameNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1742, // TestExecutionContext
                        TopLevelElementNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestExecutionContext, Microsoft.VisualStudio.TestPlatform.Core, Version" +
                                    "=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.TestExecutionContext, Microsoft.VisualStudio.TestPlatform.Core, Version" +
                                    "=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    HasDataContract = true,
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassReaderDelegate>(global::Type87.ReadTestExecutionContextFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatClassWriterDelegate>(global::Type88.WriteTestExecutionContextToXml),
                    ChildElementNamespacesListIndex = 281,
                    ContractNamespacesListIndex = 289,
                    MemberNamesListIndex = 291,
                    MemberNamespacesListIndex = 299,
                }
        };
        static readonly byte[] s_collectionDataContracts_Hashtable = null;
        // Count=21
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::CollectionDataContractEntry[] s_collectionDataContracts = new global::CollectionDataContractEntry[] {
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 331, // ArrayOfTestResult
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 331, // ArrayOfTestResult
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 331, // ArrayOfTestResult
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                                    "5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type2.ReadArrayOfTestResultFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type3.WriteArrayOfTestResultToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type4.ReadArrayOfTestResultFromXmlIsGetOnly),
                    CollectionItemNameIndex = 437, // TestResult
                    KeyNameIndex = -1,
                    ItemNameIndex = 437, // TestResult
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 459, // ArrayOfKeyValueOfTestPropertyanyTypeGfygfmPv
                        NamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 459, // ArrayOfKeyValueOfTestPropertyanyTypeGfygfmPv
                        StableNameNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 459, // ArrayOfKeyValueOfTestPropertyanyTypeGfygfmPv
                        TopLevelElementNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type9.ReadArrayOfKeyValueOfTestPropertyanyTypeGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type10.WriteArrayOfKeyValueOfTestPropertyanyTypeGfygfmPvToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type11.ReadArrayOfKeyValueOfTestPropertyanyTypeGfygfmPvFromXmlIsGetOnly),
                    CollectionItemNameIndex = 562, // KeyValueOfTestPropertyanyTypeGfygfmPv
                    KeyNameIndex = 600, // Key
                    ItemNameIndex = 562, // KeyValueOfTestPropertyanyTypeGfygfmPv
                    ValueNameIndex = 604, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestProperty, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Object, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 783, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 783, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 783, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.Collection`1, System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type18.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type19.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type20.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 804, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 804, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 818, // ArrayOfUriDataAttachment
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 818, // ArrayOfUriDataAttachment
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 818, // ArrayOfUriDataAttachment
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IList`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IList`1, System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d" +
                                    "50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type23.ReadArrayOfUriDataAttachmentFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type24.WriteArrayOfUriDataAttachmentToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type25.ReadArrayOfUriDataAttachmentFromXmlIsGetOnly),
                    CollectionItemNameIndex = 843, // UriDataAttachment
                    KeyNameIndex = -1,
                    ItemNameIndex = 843, // UriDataAttachment
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.UriDataAttachment, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 783, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 783, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 783, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.ObservableCollection`1, System.ObjectModel, Version=4.1.1.0, Culture=neutral, Pub" +
                                    "licKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type28.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type29.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type30.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 804, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 804, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 861, // ArrayOfTestResultMessage
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 861, // ArrayOfTestResultMessage
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 861, // ArrayOfTestResultMessage
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.Collection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.Collection`1, System.Runtime, Version=4.2.1.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type31.ReadArrayOfTestResultMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type32.WriteArrayOfTestResultMessageToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type33.ReadArrayOfTestResultMessageFromXmlIsGetOnly),
                    CollectionItemNameIndex = 886, // TestResultMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 886, // TestResultMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 861, // ArrayOfTestResultMessage
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 861, // ArrayOfTestResultMessage
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 861, // ArrayOfTestResultMessage
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.ObjectModel.ObservableCollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.ObjectModel, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.ObjectModel.ObservableCollection`1, System.ObjectModel, Version=4.1.1.0, Culture=neutral, Pub" +
                                    "licKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type36.ReadArrayOfTestResultMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type37.WriteArrayOfTestResultMessageToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type38.ReadArrayOfTestResultMessageFromXmlIsGetOnly),
                    CollectionItemNameIndex = 886, // TestResultMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 886, // TestResultMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResultMessage, Microsoft.VisualStudio.TestPlatform.ObjectMod" +
                                "el, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 913, // ArrayOfstring
                        NamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 913, // ArrayOfstring
                        StableNameNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 913, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String[], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type41.ReadArrayOfstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type42.WriteArrayOfstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type43.ReadArrayOfstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 927, // ArrayOfKeyValuePairOfstringstring
                        NamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        StableNameIndex = 927, // ArrayOfKeyValuePairOfstringstring
                        StableNameNamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        TopLevelElementNameIndex = 927, // ArrayOfKeyValuePairOfstringstring
                        TopLevelElementNamespaceIndex = 716, // http://schemas.datacontract.org/2004/07/System.Collections.Generic
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]][], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type44.ReadArrayOfKeyValuePairOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type45.WriteArrayOfKeyValuePairOfstringstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type46.ReadArrayOfKeyValuePairOfstringstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 961, // KeyValuePairOfstringstring
                    KeyNameIndex = -1,
                    ItemNameIndex = 961, // KeyValuePairOfstringstring
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.Array,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1187, // ArrayOfKeyValueOfTestOutcomelongGfygfmPv
                        NamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1187, // ArrayOfKeyValueOfTestOutcomelongGfygfmPv
                        StableNameNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1187, // ArrayOfKeyValueOfTestOutcomelongGfygfmPv
                        TopLevelElementNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Collections, Version=4.1.1.0, Culture=neutral, PublicKeyToken=b0" +
                                    "3f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type53.ReadArrayOfKeyValueOfTestOutcomelongGfygfmPvFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type54.WriteArrayOfKeyValueOfTestOutcomelongGfygfmPvToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type55.ReadArrayOfKeyValueOfTestOutcomelongGfygfmPvFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1228, // KeyValueOfTestOutcomelongGfygfmPv
                    KeyNameIndex = 600, // Key
                    ItemNameIndex = 1228, // KeyValueOfTestOutcomelongGfygfmPv
                    ValueNameIndex = 604, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.Int64, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1300, // ArrayOfTestCase
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 1300, // ArrayOfTestCase
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 1300, // ArrayOfTestCase
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                                    "5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type60.ReadArrayOfTestCaseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type61.WriteArrayOfTestCaseToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type62.ReadArrayOfTestCaseFromXmlIsGetOnly),
                    CollectionItemNameIndex = 904, // TestCase
                    KeyNameIndex = -1,
                    ItemNameIndex = 904, // TestCase
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                "on=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1316, // ArrayOfLogMessage
                        NamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1316, // ArrayOfLogMessage
                        StableNameNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1316, // ArrayOfLogMessage
                        TopLevelElementNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                                    "5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type63.ReadArrayOfLogMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type64.WriteArrayOfLogMessageToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type65.ReadArrayOfLogMessageFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1334, // LogMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 1334, // LogMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0," +
                                " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 913, // ArrayOfstring
                        NamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 913, // ArrayOfstring
                        StableNameNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 913, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, Publ" +
                                    "icKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7" +
                                    "f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                                    "5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type68.ReadArrayOfstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type69.WriteArrayOfstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type70.ReadArrayOfstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 783, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 783, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 783, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.List`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.List`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f" +
                                    "5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type73.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type74.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type75.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 804, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 804, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericList,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        NameIndex = 1496, // ArrayOfKeyValueOfstringstring
                        NamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1496, // ArrayOfKeyValueOfstringstring
                        StableNameNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1496, // ArrayOfKeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.Dictionary`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToke" +
                                    "n=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type76.ReadArrayOfKeyValueOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type77.WriteArrayOfKeyValueOfstringstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type78.ReadArrayOfKeyValueOfstringstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1526, // KeyValueOfstringstring
                    KeyNameIndex = 600, // Key
                    ItemNameIndex = 1526, // KeyValueOfstringstring
                    ValueNameIndex = 604, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 331, // ArrayOfTestResult
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 331, // ArrayOfTestResult
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 331, // ArrayOfTestResult
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type89.ReadArrayOfTestResultFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type90.WriteArrayOfTestResultToXml),
                    CollectionItemNameIndex = 437, // TestResult
                    KeyNameIndex = -1,
                    ItemNameIndex = 437, // TestResult
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestResult, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ver" +
                                "sion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 1300, // ArrayOfTestCase
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 1300, // ArrayOfTestCase
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 1300, // ArrayOfTestCase
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type91.ReadArrayOfTestCaseFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type92.WriteArrayOfTestCaseToXml),
                    CollectionItemNameIndex = 904, // TestCase
                    KeyNameIndex = -1,
                    ItemNameIndex = 904, // TestCase
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestCase, Microsoft.VisualStudio.TestPlatform.ObjectModel, Versi" +
                                "on=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 1316, // ArrayOfLogMessage
                        NamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1316, // ArrayOfLogMessage
                        StableNameNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1316, // ArrayOfLogMessage
                        TopLevelElementNamespaceIndex = 1106, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IEnumerable`1[[Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IEnumerable`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type93.ReadArrayOfLogMessageFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type94.WriteArrayOfLogMessageToXml),
                    CollectionItemNameIndex = 1334, // LogMessage
                    KeyNameIndex = -1,
                    ItemNameIndex = 1334, // LogMessage
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericEnumerable,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.LogMessage, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0.0," +
                                " Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 913, // ArrayOfstring
                        NamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 913, // ArrayOfstring
                        StableNameNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 913, // ArrayOfstring
                        TopLevelElementNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutra" +
                                    "l, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=" +
                                    "b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type95.ReadArrayOfstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type96.WriteArrayOfstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type97.ReadArrayOfstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 180, // string
                    KeyNameIndex = -1,
                    ItemNameIndex = 180, // string
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericCollection,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 783, // ArrayOfAttachmentSet
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 783, // ArrayOfAttachmentSet
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 783, // ArrayOfAttachmentSet
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.ICollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.ICollection`1[[Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.ICollection`1, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type98.ReadArrayOfAttachmentSetFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type99.WriteArrayOfAttachmentSetToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type100.ReadArrayOfAttachmentSetFromXmlIsGetOnly),
                    CollectionItemNameIndex = 804, // AttachmentSet
                    KeyNameIndex = -1,
                    ItemNameIndex = 804, // AttachmentSet
                    ValueNameIndex = -1,
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericCollection,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.AttachmentSet, Microsoft.VisualStudio.TestPlatform.ObjectModel, " +
                                "Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }, 
                new global::CollectionDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        TypeIsCollectionInterface = true,
                        TypeIsInterface = true,
                        NameIndex = 1496, // ArrayOfKeyValueOfstringstring
                        NamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        StableNameIndex = 1496, // ArrayOfKeyValueOfstringstring
                        StableNameNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        TopLevelElementNameIndex = 1496, // ArrayOfKeyValueOfstringstring
                        TopLevelElementNamespaceIndex = 504, // http://schemas.microsoft.com/2003/10/Serialization/Arrays
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Collections.Generic.IDictionary`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        GenericTypeDefinition = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("System.Collections.Generic.IDictionary`2, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyTok" +
                                    "en=b03f5f7f11d50a3a")),
                    },
                    XmlFormatReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionReaderDelegate>(global::Type101.ReadArrayOfKeyValueOfstringstringFromXml),
                    XmlFormatWriterDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatCollectionWriterDelegate>(global::Type102.WriteArrayOfKeyValueOfstringstringToXml),
                    XmlFormatGetOnlyCollectionReaderDelegate = global::SgIntrinsics.AddrOf<global::System.Runtime.Serialization.XmlFormatGetOnlyCollectionReaderDelegate>(global::Type103.ReadArrayOfKeyValueOfstringstringFromXmlIsGetOnly),
                    CollectionItemNameIndex = 1526, // KeyValueOfstringstring
                    KeyNameIndex = 600, // Key
                    ItemNameIndex = 1526, // KeyValueOfstringstring
                    ValueNameIndex = 604, // Value
                    CollectionContractKind = global::System.Runtime.Serialization.CollectionKind.GenericDictionary,
                    ItemType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf(@"System.Runtime.Serialization.KeyValue`2[[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a],[System.String, System.Private.CoreLib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Private.DataContractSerialization, Version=4.1.4.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                }
        };
        static readonly byte[] s_enumDataContracts_Hashtable = null;
        // Count=4
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::EnumDataContractEntry[] s_enumDataContracts = new global::EnumDataContractEntry[] {
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 623, // TestPropertyAttributes
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 623, // TestPropertyAttributes
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 623, // TestPropertyAttributes
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.Obje" +
                                    "ctModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestPropertyAttributes, Microsoft.VisualStudio.TestPlatform.Obje" +
                                    "ctModel, Version=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    IsFlags = true,
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 81,
                    MemberCount = 4,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 988, // TestOutcome
                        NamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        StableNameIndex = 988, // TestOutcome
                        StableNameNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        TopLevelElementNameIndex = 988, // TestOutcome
                        TopLevelElementNamespaceIndex = 349, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ve" +
                                    "rsion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.TestOutcome, Microsoft.VisualStudio.TestPlatform.ObjectModel, Ve" +
                                    "rsion=14.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 153,
                    MemberCount = 5,
                    MemberListIndex = 4,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1345, // TestMessageLevel
                        NamespaceIndex = 1362, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging
                        StableNameIndex = 1345, // TestMessageLevel
                        StableNameNamespaceIndex = 1362, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging
                        TopLevelElementNameIndex = 1345, // TestMessageLevel
                        TopLevelElementNamespaceIndex = 1362, // http://schemas.datacontract.org/2004/07/Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.Ob" +
                                    "jectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.ObjectModel.Logging.TestMessageLevel, Microsoft.VisualStudio.TestPlatform.Ob" +
                                    "jectModel, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 214,
                    MemberCount = 3,
                    MemberListIndex = 9,
                }, 
                new global::EnumDataContractEntry() {
                    Common = new global::CommonContractEntry() {
                        HasRoot = true,
                        IsValueType = true,
                        NameIndex = 1561, // ContractName
                        NamespaceIndex = 1574, // Microsoft.VisualStudio.TestPlatform.Core
                        StableNameIndex = 1561, // ContractName
                        StableNameNamespaceIndex = 1574, // Microsoft.VisualStudio.TestPlatform.Core
                        TopLevelElementNameIndex = 1561, // ContractName
                        TopLevelElementNamespaceIndex = 1574, // Microsoft.VisualStudio.TestPlatform.Core
                        OriginalUnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                        UnderlyingType = new global::Internal.Runtime.CompilerServices.FixupRuntimeTypeHandle(global::System.Runtime.InteropServices.TypeOfHelper.RuntimeTypeHandleOf("Microsoft.VisualStudio.TestPlatform.Core.ContractName, Microsoft.VisualStudio.TestPlatform.Core, Version=14.0.0." +
                                    "0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")),
                    },
                    BaseContractNameIndex = -1,
                    BaseContractNamespaceIndex = -1,
                    ChildElementNamesListIndex = 243,
                    MemberCount = 6,
                    MemberListIndex = 12,
                }
        };
        static readonly byte[] s_xmlDataContracts_Hashtable = null;
        // Count=0
        [global::System.Runtime.CompilerServices.PreInitialized]
        static readonly global::XmlDataContractEntry[] s_xmlDataContracts = new global::XmlDataContractEntry[0];
        static char[] s_stringPool = new char[] {
            'b','o','o','l','e','a','n','\0','h','t','t','p',':','/','/','w','w','w','.','w','3','.','o','r','g','/','2','0','0','1',
            '/','X','M','L','S','c','h','e','m','a','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','m','i','c','r',
            'o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0','/','S','e','r','i','a','l','i','z','a','t','i','o',
            'n','/','\0','b','a','s','e','6','4','B','i','n','a','r','y','\0','c','h','a','r','\0','d','a','t','e','T','i','m','e','\0',
            'd','e','c','i','m','a','l','\0','d','o','u','b','l','e','\0','f','l','o','a','t','\0','g','u','i','d','\0','i','n','t','\0',
            'l','o','n','g','\0','a','n','y','T','y','p','e','\0','Q','N','a','m','e','\0','s','h','o','r','t','\0','b','y','t','e','\0',
            's','t','r','i','n','g','\0','d','u','r','a','t','i','o','n','\0','u','n','s','i','g','n','e','d','B','y','t','e','\0','u',
            'n','s','i','g','n','e','d','I','n','t','\0','u','n','s','i','g','n','e','d','L','o','n','g','\0','u','n','s','i','g','n',
            'e','d','S','h','o','r','t','\0','a','n','y','U','R','I','\0','E','x','c','e','p','t','i','o','n','D','e','t','a','i','l',
            '\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o',
            'r','g','/','2','0','0','4','/','0','7','/','S','y','s','t','e','m','.','S','e','r','v','i','c','e','M','o','d','e','l',
            '\0','A','r','r','a','y','O','f','T','e','s','t','R','e','s','u','l','t','\0','h','t','t','p',':','/','/','s','c','h','e',
            'm','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M',
            'i','c','r','o','s','o','f','t','.','V','i','s','u','a','l','S','t','u','d','i','o','.','T','e','s','t','P','l','a','t',
            'f','o','r','m','.','O','b','j','e','c','t','M','o','d','e','l','\0','T','e','s','t','R','e','s','u','l','t','\0','T','e',
            's','t','O','b','j','e','c','t','\0','A','r','r','a','y','O','f','K','e','y','V','a','l','u','e','O','f','T','e','s','t',
            'P','r','o','p','e','r','t','y','a','n','y','T','y','p','e','G','f','y','g','f','m','P','v','\0','h','t','t','p',':','/',
            '/','s','c','h','e','m','a','s','.','m','i','c','r','o','s','o','f','t','.','c','o','m','/','2','0','0','3','/','1','0',
            '/','S','e','r','i','a','l','i','z','a','t','i','o','n','/','A','r','r','a','y','s','\0','K','e','y','V','a','l','u','e',
            'O','f','T','e','s','t','P','r','o','p','e','r','t','y','a','n','y','T','y','p','e','G','f','y','g','f','m','P','v','\0',
            'K','e','y','\0','V','a','l','u','e','\0','T','e','s','t','P','r','o','p','e','r','t','y','\0','T','e','s','t','P','r','o',
            'p','e','r','t','y','A','t','t','r','i','b','u','t','e','s','\0','N','o','n','e','\0','H','i','d','d','e','n','\0','I','m',
            'm','u','t','a','b','l','e','\0','T','r','a','i','t','\0','K','e','y','V','a','l','u','e','P','a','i','r','O','f','T','e',
            's','t','P','r','o','p','e','r','t','y','a','n','y','T','y','p','e','G','f','y','g','f','m','P','v','\0','h','t','t','p',
            ':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0',
            '0','4','/','0','7','/','S','y','s','t','e','m','.','C','o','l','l','e','c','t','i','o','n','s','.','G','e','n','e','r',
            'i','c','\0','A','r','r','a','y','O','f','A','t','t','a','c','h','m','e','n','t','S','e','t','\0','A','t','t','a','c','h',
            'm','e','n','t','S','e','t','\0','A','r','r','a','y','O','f','U','r','i','D','a','t','a','A','t','t','a','c','h','m','e',
            'n','t','\0','U','r','i','D','a','t','a','A','t','t','a','c','h','m','e','n','t','\0','A','r','r','a','y','O','f','T','e',
            's','t','R','e','s','u','l','t','M','e','s','s','a','g','e','\0','T','e','s','t','R','e','s','u','l','t','M','e','s','s',
            'a','g','e','\0','T','e','s','t','C','a','s','e','\0','A','r','r','a','y','O','f','s','t','r','i','n','g','\0','A','r','r',
            'a','y','O','f','K','e','y','V','a','l','u','e','P','a','i','r','O','f','s','t','r','i','n','g','s','t','r','i','n','g',
            '\0','K','e','y','V','a','l','u','e','P','a','i','r','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','T','e',
            's','t','O','u','t','c','o','m','e','\0','P','a','s','s','e','d','\0','F','a','i','l','e','d','\0','S','k','i','p','p','e',
            'd','\0','N','o','t','F','o','u','n','d','\0','D','a','t','e','T','i','m','e','O','f','f','s','e','t','\0','h','t','t','p',
            ':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0',
            '0','4','/','0','7','/','S','y','s','t','e','m','\0','T','e','s','t','R','u','n','S','t','a','t','s','\0','h','t','t','p',
            ':','/','/','s','c','h','e','m','a','s','.','d','a','t','a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0',
            '0','4','/','0','7','/','M','i','c','r','o','s','o','f','t','.','V','i','s','u','a','l','S','t','u','d','i','o','.','T',
            'e','s','t','P','l','a','t','f','o','r','m','.','C','o','r','e','\0','A','r','r','a','y','O','f','K','e','y','V','a','l',
            'u','e','O','f','T','e','s','t','O','u','t','c','o','m','e','l','o','n','g','G','f','y','g','f','m','P','v','\0','K','e',
            'y','V','a','l','u','e','O','f','T','e','s','t','O','u','t','c','o','m','e','l','o','n','g','G','f','y','g','f','m','P',
            'v','\0','K','e','y','V','a','l','u','e','P','a','i','r','O','f','T','e','s','t','O','u','t','c','o','m','e','l','o','n',
            'g','G','f','y','g','f','m','P','v','\0','A','r','r','a','y','O','f','T','e','s','t','C','a','s','e','\0','A','r','r','a',
            'y','O','f','L','o','g','M','e','s','s','a','g','e','\0','L','o','g','M','e','s','s','a','g','e','\0','T','e','s','t','M',
            'e','s','s','a','g','e','L','e','v','e','l','\0','h','t','t','p',':','/','/','s','c','h','e','m','a','s','.','d','a','t',
            'a','c','o','n','t','r','a','c','t','.','o','r','g','/','2','0','0','4','/','0','7','/','M','i','c','r','o','s','o','f',
            't','.','V','i','s','u','a','l','S','t','u','d','i','o','.','T','e','s','t','P','l','a','t','f','o','r','m','.','O','b',
            'j','e','c','t','M','o','d','e','l','.','L','o','g','g','i','n','g','\0','I','n','f','o','r','m','a','t','i','o','n','a',
            'l','\0','W','a','r','n','i','n','g','\0','E','r','r','o','r','\0','E','x','c','e','p','t','i','o','n','\0','A','r','r','a',
            'y','O','f','K','e','y','V','a','l','u','e','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','K','e','y','V',
            'a','l','u','e','O','f','s','t','r','i','n','g','s','t','r','i','n','g','\0','P','o','l','l','R','e','q','u','e','s','t',
            '\0','C','o','n','t','r','a','c','t','N','a','m','e','\0','M','i','c','r','o','s','o','f','t','.','V','i','s','u','a','l',
            'S','t','u','d','i','o','.','T','e','s','t','P','l','a','t','f','o','r','m','.','C','o','r','e','\0','C','a','n','c','e',
            'l','T','e','s','t','R','u','n','\0','I','n','i','t','i','a','l','i','z','e','C','o','n','n','e','c','t','i','o','n','\0',
            'S','h','u','t','d','o','w','n','\0','S','t','a','r','t','T','e','s','t','R','u','n','\0','S','t','a','r','t','T','e','s',
            't','R','u','n','W','i','t','h','S','o','u','r','c','e','s','\0','I','n','i','t','i','a','l','i','z','e','C','o','n','n',
            'e','c','t','i','o','n','P','a','r','a','m','s','\0','S','t','a','r','t','T','e','s','t','R','u','n','P','a','r','a','m',
            's','\0','T','e','s','t','E','x','e','c','u','t','i','o','n','C','o','n','t','e','x','t','\0','H','e','l','p','L','i','n',
            'k','\0','I','n','n','e','r','E','x','c','e','p','t','i','o','n','\0','M','e','s','s','a','g','e','\0','S','t','a','c','k',
            'T','r','a','c','e','\0','T','y','p','e','\0','s','t','o','r','e','\0','A','t','t','a','c','h','m','e','n','t','s','\0','M',
            'e','s','s','a','g','e','s','\0','_','a','t','t','r','i','b','u','t','e','s','\0','_','c','a','t','e','g','o','r','y','\0',
            '_','d','e','s','c','r','i','p','t','i','o','n','\0','_','i','d','\0','_','l','a','b','e','l','\0','_','s','t','r','V','a',
            'l','u','e','T','y','p','e','\0','k','e','y','\0','v','a','l','u','e','\0','D','i','s','p','l','a','y','N','a','m','e','\0',
            'U','r','i','\0','D','e','s','c','r','i','p','t','i','o','n','\0','C','a','t','e','g','o','r','y','\0','T','e','x','t','\0',
            'D','a','t','e','T','i','m','e','\0','O','f','f','s','e','t','M','i','n','u','t','e','s','\0','E','x','e','c','u','t','e',
            'd','T','e','s','t','s','\0','S','t','a','t','s','\0','M','e','s','s','a','g','e','L','e','v','e','l','\0','C','o','n','t',
            'r','a','c','t','\0','I','n','i','t','P','a','r','a','m','s','\0','T','e','s','t','R','u','n','P','a','r','a','m','s','\0',
            'L','o','a','d','O','n','l','y','W','e','l','l','K','n','o','w','n','E','x','t','e','n','s','i','o','n','s','\0','P','a',
            't','h','T','o','A','d','d','i','t','i','o','n','a','l','E','x','t','e','n','s','i','o','n','s','\0','D','a','t','a','C',
            'o','l','l','e','c','t','o','r','S','e','r','v','i','c','e','U','r','i','\0','E','x','e','c','u','t','i','o','n','C','o',
            'n','t','e','x','t','\0','S','o','u','r','c','e','s','\0','T','e','s','t','R','u','n','S','e','t','t','i','n','g','s','\0',
            'T','e','s','t','s','\0','A','r','e','T','e','s','t','C','a','s','e','L','e','v','e','l','E','v','e','n','t','s','R','e',
            'q','u','i','r','e','d','\0','F','r','e','q','u','e','n','c','y','O','f','R','u','n','S','t','a','t','s','C','h','a','n',
            'g','e','E','v','e','n','t','\0','I','n','I','s','o','l','a','t','i','o','n','\0','I','s','D','e','b','u','g','\0','K','e',
            'e','p','A','l','i','v','e','\0','R','u','n','S','t','a','t','s','C','h','a','n','g','e','E','v','e','n','t','T','i','m',
            'e','o','u','t','\0','T','e','s','t','C','a','s','e','F','i','l','t','e','r','\0'};
    }
}
