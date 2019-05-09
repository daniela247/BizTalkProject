namespace BizTalkUseCase3.Maps.REST.PaymentSystem {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkUseCase3.Schemas.PaymentSystem.AddMoneyPayment", typeof(global::BizTalkUseCase3.Schemas.PaymentSystem.AddMoneyPayment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkUseCase3.Schemas.REST.AddMoneyPayment_Json", typeof(global::BizTalkUseCase3.Schemas.REST.AddMoneyPayment_Json))]
    public sealed class Payment_Money_to_REST : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://BizTalkUseCase3.Schemas.REST.AddMoneyPayment_Json"" xmlns:s0=""http://BizTalkUseCase3.Schemas.PaymentSystem.AddMoneyPayment"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AddMoneyPayment"" />
  </xsl:template>
  <xsl:template match=""/s0:AddMoneyPayment"">
    <ns0:AddMoneyPayment>
      <card>
        <xsl:value-of select=""cardId/text()"" />
      </card>
      <chf>
        <xsl:value-of select=""money/text()"" />
      </chf>
    </ns0:AddMoneyPayment>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkUseCase3.Schemas.PaymentSystem.AddMoneyPayment";
        
        private const global::BizTalkUseCase3.Schemas.PaymentSystem.AddMoneyPayment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkUseCase3.Schemas.REST.AddMoneyPayment_Json";
        
        private const global::BizTalkUseCase3.Schemas.REST.AddMoneyPayment_Json _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BizTalkUseCase3.Schemas.PaymentSystem.AddMoneyPayment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkUseCase3.Schemas.REST.AddMoneyPayment_Json";
                return _TrgSchemas;
            }
        }
    }
}
