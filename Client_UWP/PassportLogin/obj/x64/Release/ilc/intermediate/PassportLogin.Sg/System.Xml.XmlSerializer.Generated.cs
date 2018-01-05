extern alias System_Runtime_Extensions;
namespace System.Runtime.CompilerServices {
    internal class __BlockReflectionAttribute : Attribute { }
}

namespace Microsoft.Xml.Serialization.GeneratedAssembly {


    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write5_ArrayOfAccount(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ArrayOfAccount", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace1 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::PassportLogin.Models.Account> a = (global::System.Collections.Generic.List<global::PassportLogin.Models.Account>)((global::System.Collections.Generic.List<global::PassportLogin.Models.Account>)o);
                if ((object)(a) == null) {
                    WriteNullTagLiteral(@"ArrayOfAccount", defaultNamespace);
                }
                else {
                    WriteStartElement(@"ArrayOfAccount", namespace1, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace2 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write2_Account(@"Account", namespace2, ((global::PassportLogin.Models.Account)a[ia]), true, false, namespace2, @"");
                    }
                    WriteEndElement();
                }
            }
        }

        public void Write6_ArrayOfUserAccount(object o, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs ?? @"";
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ArrayOfUserAccount", defaultNamespace);
                return;
            }
            TopLevelElement();
            string namespace3 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::PassportLogin.AuthService.UserAccount> a = (global::System.Collections.Generic.List<global::PassportLogin.AuthService.UserAccount>)((global::System.Collections.Generic.List<global::PassportLogin.AuthService.UserAccount>)o);
                if ((object)(a) == null) {
                    WriteNullTagLiteral(@"ArrayOfUserAccount", defaultNamespace);
                }
                else {
                    WriteStartElement(@"ArrayOfUserAccount", namespace3, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace4 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write4_UserAccount(@"UserAccount", namespace4, ((global::PassportLogin.AuthService.UserAccount)a[ia]), true, false, namespace4, @"");
                    }
                    WriteEndElement();
                }
            }
        }

        void Write4_UserAccount(string n, string ns, global::PassportLogin.AuthService.UserAccount o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::PassportLogin.AuthService.UserAccount)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"UserAccount", defaultNamespace);
            string namespace5 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            {
                global::System.Collections.Generic.List<global::PassportLogin.AuthService.PassportDevice> a = (global::System.Collections.Generic.List<global::PassportLogin.AuthService.PassportDevice>)((global::System.Collections.Generic.List<global::PassportLogin.AuthService.PassportDevice>)o.@PassportDevices);
                if (a != null){
                    WriteStartElement(@"PassportDevices", namespace5, null, false);
                    for (int ia = 0; ia < ((System.Collections.ICollection)a).Count; ia++) {
                        string namespace6 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
                        Write3_PassportDevice(@"PassportDevice", namespace6, ((global::PassportLogin.AuthService.PassportDevice)a[ia]), true, false, namespace6, @"");
                    }
                    WriteEndElement();
                }
            }
            string namespace7 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"UserId", namespace7, System.Xml.XmlConvert.ToString((global::System.Guid)((global::System.Guid)o.@UserId)));
            string namespace8 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Username", namespace8, ((global::System.String)o.@Username));
            string namespace9 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Password", namespace9, ((global::System.String)o.@Password));
            WriteEndElement(o);
        }

        void Write3_PassportDevice(string n, string ns, global::PassportLogin.AuthService.PassportDevice o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::PassportLogin.AuthService.PassportDevice)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PassportDevice", defaultNamespace);
            string namespace10 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"DeviceId", namespace10, System.Xml.XmlConvert.ToString((global::System.Guid)((global::System.Guid)o.@DeviceId)));
            string namespace11 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementStringRaw(@"PublicKey", namespace11, FromByteArrayBase64(((global::System.Byte[])o.@PublicKey)));
            WriteEndElement(o);
        }

        void Write2_Account(string n, string ns, global::PassportLogin.Models.Account o, bool isNullable, bool needType, string parentRuntimeNs = null, string parentCompileTimeNs = null) {
            string defaultNamespace = parentRuntimeNs;
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::PassportLogin.Models.Account)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Account", defaultNamespace);
            string namespace12 = ( parentCompileTimeNs == @"" && parentRuntimeNs != null ) ? parentRuntimeNs : @"";
            WriteElementString(@"Username", namespace12, ((global::System.String)o.@Username));
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read5_ArrayOfAccount(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id1_ArrayOfAccount && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    if (!ReadNull()) {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::PassportLogin.Models.Account>();
                        global::System.Collections.Generic.List<global::PassportLogin.Models.Account> a_0_0 = (global::System.Collections.Generic.List<global::PassportLogin.Models.Account>)o;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations0 = 0;
                            int readerCount0 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id3_Account && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read2_Account(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":Account");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":Account");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations0, ref readerCount0);
                            }
                        ReadEndElement();
                        }
                    }
                    else {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::PassportLogin.Models.Account>();
                        global::System.Collections.Generic.List<global::PassportLogin.Models.Account> a_0_0 = (global::System.Collections.Generic.List<global::PassportLogin.Models.Account>)o;
                    }
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":ArrayOfAccount");
            }
            return (object)o;
        }

        public object Read6_ArrayOfUserAccount(string defaultNamespace = null) {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                if (((object) Reader.LocalName == (object)id4_ArrayOfUserAccount && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                    if (!ReadNull()) {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::PassportLogin.AuthService.UserAccount>();
                        global::System.Collections.Generic.List<global::PassportLogin.AuthService.UserAccount> a_0_0 = (global::System.Collections.Generic.List<global::PassportLogin.AuthService.UserAccount>)o;
                        if ((Reader.IsEmptyElement)) {
                            Reader.Skip();
                        }
                        else {
                            Reader.ReadStartElement();
                            Reader.MoveToContent();
                            int whileIterations1 = 0;
                            int readerCount1 = ReaderCount;
                            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                    if (((object) Reader.LocalName == (object)id5_UserAccount && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                        if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read4_UserAccount(true, true, defaultNamespace));
                                    }
                                    else {
                                        UnknownNode(null, @":UserAccount");
                                    }
                                }
                                else {
                                    UnknownNode(null, @":UserAccount");
                                }
                                Reader.MoveToContent();
                                CheckReaderCount(ref whileIterations1, ref readerCount1);
                            }
                        ReadEndElement();
                        }
                    }
                    else {
                        if ((object)(o) == null) o = new global::System.Collections.Generic.List<global::PassportLogin.AuthService.UserAccount>();
                        global::System.Collections.Generic.List<global::PassportLogin.AuthService.UserAccount> a_0_0 = (global::System.Collections.Generic.List<global::PassportLogin.AuthService.UserAccount>)o;
                    }
                }
                else {
                    throw CreateUnknownNodeException();
                }
            }
            else {
                UnknownNode(null, defaultNamespace ?? @":ArrayOfUserAccount");
            }
            return (object)o;
        }

        global::PassportLogin.AuthService.UserAccount Read4_UserAccount(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id5_UserAccount && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::PassportLogin.AuthService.UserAccount o;
            o = new global::PassportLogin.AuthService.UserAccount();
            if ((object)(o.@PassportDevices) == null) o.@PassportDevices = new global::System.Collections.Generic.List<global::PassportLogin.AuthService.PassportDevice>();
            global::System.Collections.Generic.List<global::PassportLogin.AuthService.PassportDevice> a_0 = (global::System.Collections.Generic.List<global::PassportLogin.AuthService.PassportDevice>)o.@PassportDevices;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations2 = 0;
            int readerCount2 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (((object) Reader.LocalName == (object)id6_PassportDevices && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        if (!ReadNull()) {
                            if ((object)(o.@PassportDevices) == null) o.@PassportDevices = new global::System.Collections.Generic.List<global::PassportLogin.AuthService.PassportDevice>();
                            global::System.Collections.Generic.List<global::PassportLogin.AuthService.PassportDevice> a_0_0 = (global::System.Collections.Generic.List<global::PassportLogin.AuthService.PassportDevice>)o.@PassportDevices;
                            if ((Reader.IsEmptyElement)) {
                                Reader.Skip();
                            }
                            else {
                                Reader.ReadStartElement();
                                Reader.MoveToContent();
                                int whileIterations3 = 0;
                                int readerCount3 = ReaderCount;
                                while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                    if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                        if (((object) Reader.LocalName == (object)id7_PassportDevice && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                                            if ((object)(a_0_0) == null) Reader.Skip(); else a_0_0.Add(Read3_PassportDevice(true, true, defaultNamespace));
                                        }
                                        else {
                                            UnknownNode(null, @":PassportDevice");
                                        }
                                    }
                                    else {
                                        UnknownNode(null, @":PassportDevice");
                                    }
                                    Reader.MoveToContent();
                                    CheckReaderCount(ref whileIterations3, ref readerCount3);
                                }
                            ReadEndElement();
                            }
                        }
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id8_UserId && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@UserId = System.Xml.XmlConvert.ToGuid(Reader.ReadElementContentAsString());
                        }
                        paramsRead[1] = true;
                    }
                    else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id9_Username && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Username = Reader.ReadElementContentAsString();
                        }
                        paramsRead[2] = true;
                    }
                    else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id10_Password && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Password = Reader.ReadElementContentAsString();
                        }
                        paramsRead[3] = true;
                    }
                    else {
                        UnknownNode((object)o, @":PassportDevices, :UserId, :Username, :Password");
                    }
                }
                else {
                    UnknownNode((object)o, @":PassportDevices, :UserId, :Username, :Password");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations2, ref readerCount2);
            }
            ReadEndElement();
            return o;
        }

        global::PassportLogin.AuthService.PassportDevice Read3_PassportDevice(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_PassportDevice && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::PassportLogin.AuthService.PassportDevice o;
            o = new global::PassportLogin.AuthService.PassportDevice();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations4 = 0;
            int readerCount4 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id11_DeviceId && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@DeviceId = System.Xml.XmlConvert.ToGuid(Reader.ReadElementContentAsString());
                        }
                        paramsRead[0] = true;
                    }
                    else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id12_PublicKey && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@PublicKey = ToByteArrayBase64(false);
                        }
                        paramsRead[1] = true;
                    }
                    else {
                        UnknownNode((object)o, @":DeviceId, :PublicKey");
                    }
                }
                else {
                    UnknownNode((object)o, @":DeviceId, :PublicKey");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations4, ref readerCount4);
            }
            ReadEndElement();
            return o;
        }

        global::PassportLogin.Models.Account Read2_Account(bool isNullable, bool checkType, string defaultNamespace = null) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_Account && string.Equals( ((System.Xml.XmlQualifiedName)xsiType).Namespace, defaultNamespace ?? id2_Item))) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::PassportLogin.Models.Account o;
            o = new global::PassportLogin.Models.Account();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations5 = 0;
            int readerCount5 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    if (!paramsRead[0] && ((object) Reader.LocalName == (object)id9_Username && string.Equals(Reader.NamespaceURI, defaultNamespace ?? id2_Item))) {
                        {
                            o.@Username = Reader.ReadElementContentAsString();
                        }
                        paramsRead[0] = true;
                    }
                    else {
                        UnknownNode((object)o, @":Username");
                    }
                }
                else {
                    UnknownNode((object)o, @":Username");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations5, ref readerCount5);
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id9_Username;
        string id11_DeviceId;
        string id6_PassportDevices;
        string id3_Account;
        string id7_PassportDevice;
        string id5_UserAccount;
        string id10_Password;
        string id12_PublicKey;
        string id2_Item;
        string id4_ArrayOfUserAccount;
        string id8_UserId;
        string id1_ArrayOfAccount;

        protected override void InitIDs() {
            id9_Username = Reader.NameTable.Add(@"Username");
            id11_DeviceId = Reader.NameTable.Add(@"DeviceId");
            id6_PassportDevices = Reader.NameTable.Add(@"PassportDevices");
            id3_Account = Reader.NameTable.Add(@"Account");
            id7_PassportDevice = Reader.NameTable.Add(@"PassportDevice");
            id5_UserAccount = Reader.NameTable.Add(@"UserAccount");
            id10_Password = Reader.NameTable.Add(@"Password");
            id12_PublicKey = Reader.NameTable.Add(@"PublicKey");
            id2_Item = Reader.NameTable.Add(@"");
            id4_ArrayOfUserAccount = Reader.NameTable.Add(@"ArrayOfUserAccount");
            id8_UserId = Reader.NameTable.Add(@"UserId");
            id1_ArrayOfAccount = Reader.NameTable.Add(@"ArrayOfAccount");
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ListOfAccountSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ArrayOfAccount", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write5_ArrayOfAccount(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read5_ArrayOfAccount(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public sealed class ListOfUserAccountSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ArrayOfUserAccount", this.DefaultNamespace ?? @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write6_ArrayOfUserAccount(objectToSerialize, this.DefaultNamespace, @"");
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read6_ArrayOfUserAccount(this.DefaultNamespace);
        }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System_Runtime_Extensions::System.Collections.Hashtable readMethods = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp[@"System.Collections.Generic.List`1[[PassportLogin.Models.Account, PassportLogin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]::"] = @"Read5_ArrayOfAccount";
                    _tmp[@"System.Collections.Generic.List`1[[PassportLogin.AuthService.UserAccount, PassportLogin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]::"] = @"Read6_ArrayOfUserAccount";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System_Runtime_Extensions::System.Collections.Hashtable writeMethods = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp[@"System.Collections.Generic.List`1[[PassportLogin.Models.Account, PassportLogin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]::"] = @"Write5_ArrayOfAccount";
                    _tmp[@"System.Collections.Generic.List`1[[PassportLogin.AuthService.UserAccount, PassportLogin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]::"] = @"Write6_ArrayOfUserAccount";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System_Runtime_Extensions::System.Collections.Hashtable typedSerializers = null;
        public override System_Runtime_Extensions::System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System_Runtime_Extensions::System.Collections.Hashtable _tmp = new System_Runtime_Extensions::System.Collections.Hashtable();
                    _tmp.Add(@"System.Collections.Generic.List`1[[PassportLogin.Models.Account, PassportLogin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]::", new ListOfAccountSerializer());
                    _tmp.Add(@"System.Collections.Generic.List`1[[PassportLogin.AuthService.UserAccount, PassportLogin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null]]::", new ListOfUserAccountSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::System.Collections.Generic.List<global::PassportLogin.Models.Account>)) return true;
            if (type == typeof(global::System.Collections.Generic.List<global::PassportLogin.AuthService.UserAccount>)) return true;
            if (type == typeof(global::System.Reflection.TypeInfo)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::System.Collections.Generic.List<global::PassportLogin.Models.Account>)) return new ListOfAccountSerializer();
            if (type == typeof(global::System.Collections.Generic.List<global::PassportLogin.AuthService.UserAccount>)) return new ListOfUserAccountSerializer();
            return null;
        }
        public static global::System.Xml.Serialization.XmlSerializerImplementation GetXmlSerializerContract() { return new XmlSerializerContract(); }
    }

    [System.Runtime.CompilerServices.__BlockReflection]
    public static class ActivatorHelper {
        public static object CreateInstance(System.Type type) {
            System.Reflection.TypeInfo ti = System.Reflection.IntrospectionExtensions.GetTypeInfo(type);
            foreach (System.Reflection.ConstructorInfo ci in ti.DeclaredConstructors) {
                if (!ci.IsStatic && ci.GetParameters().Length == 0) {
                    return ci.Invoke(null);
                }
            }
            return System.Activator.CreateInstance(type);
        }
    }
}
