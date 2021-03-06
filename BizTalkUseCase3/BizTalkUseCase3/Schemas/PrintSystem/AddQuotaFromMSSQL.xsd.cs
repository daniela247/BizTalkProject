namespace BizTalkUseCase3.Schemas.PrintSystem {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalkUseCase3.Schemas.PrintSystem.AddQuotaFromMSSQL",@"AddQuotaFromMSSQL")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddQuotaFromMSSQL"})]
    public sealed class AddQuotaFromMSSQL : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalkUseCase3.Schemas.PrintSystem.AddQuotaFromMSSQL"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalkUseCase3.Schemas.PrintSystem.AddQuotaFromMSSQL"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""AddQuotaFromMSSQL"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""UID"" type=""xs:unsignedInt"" />
        <xs:element name=""Money"" type=""xs:decimal"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AddQuotaFromMSSQL() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AddQuotaFromMSSQL";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
