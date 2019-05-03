namespace BizTalkUseCase3.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalkUseCase3.Schemas.AddMoneyPayment",@"AddMoneyPayment")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BizTalkUseCase3.PropertySchema.Money), XPath = @"/*[local-name()='AddMoneyPayment' and namespace-uri()='http://BizTalkUseCase3.Schemas.AddMoneyPayment']/*[local-name()='Money' and namespace-uri()='']", XsdType = @"decimal")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"AddMoneyPayment"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkUseCase3.PropertySchema.PropertySchema", typeof(global::BizTalkUseCase3.PropertySchema.PropertySchema))]
    public sealed class AddMoneyPayment : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalkUseCase3.Schemas.AddMoneyPayment"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://BizTalkUseCase3.PropertySchema"" targetNamespace=""http://BizTalkUseCase3.Schemas.AddMoneyPayment"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://BizTalkUseCase3.PropertySchema"" location=""BizTalkUseCase3.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""AddMoneyPayment"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Money"" xpath=""/*[local-name()='AddMoneyPayment' and namespace-uri()='http://BizTalkUseCase3.Schemas.AddMoneyPayment']/*[local-name()='Money' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""CardId"" type=""xs:string"" />
        <xs:element name=""Money"" type=""xs:decimal"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AddMoneyPayment() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "AddMoneyPayment";
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
