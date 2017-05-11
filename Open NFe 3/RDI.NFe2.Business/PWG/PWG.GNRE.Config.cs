﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace RDI.NFe2.Business.PWG.GNRE.Config
{
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "GnreConfigUF", Namespace = "http://www.gnre.pe.gov.br/webservice/GnreConfigUF")]
    public partial class GnreConfigUF : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private gnreCabecMsg gnreCabecMsgValueField;

        private System.Threading.SendOrPostCallback consultarOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        public GnreConfigUF()
        {
            this.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap12;
            this.Url = "https://www.gnre.pe.gov.br/gnreWS/services/GnreConfigUF";
            if ((this.IsLocalFileSystemWebService(this.Url) == true))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        public gnreCabecMsg gnreCabecMsgValue
        {
            get
            {
                return this.gnreCabecMsgValueField;
            }
            set
            {
                this.gnreCabecMsgValueField = value;
            }
        }

        public new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true)
                            && (this.useDefaultCredentialsSetExplicitly == false))
                            && (this.IsLocalFileSystemWebService(value) == false)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        /// <remarks/>
        public event consultarCompletedEventHandler consultarCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("gnreCabecMsgValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.gnre.pe.gov.br/webservice/GnreConfigUF/consultar", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("gnreRespostaMsg", Namespace = "http://www.gnre.pe.gov.br/webservice/GnreConfigUF")]
        public System.Xml.XmlNode consultar([System.Xml.Serialization.XmlElementAttribute(Namespace = "http://www.gnre.pe.gov.br/webservice/GnreConfigUF")] System.Xml.XmlNode gnreDadosMsg)
        {
            object[] results = this.Invoke("consultar", new object[] {
                        gnreDadosMsg});
            return ((System.Xml.XmlNode)(results[0]));
        }

        /// <remarks/>
        public void consultarAsync(System.Xml.XmlNode gnreDadosMsg)
        {
            this.consultarAsync(gnreDadosMsg, null);
        }

        /// <remarks/>
        public void consultarAsync(System.Xml.XmlNode gnreDadosMsg, object userState)
        {
            if ((this.consultarOperationCompleted == null))
            {
                this.consultarOperationCompleted = new System.Threading.SendOrPostCallback(this.OnconsultarOperationCompleted);
            }
            this.InvokeAsync("consultar", new object[] {
                        gnreDadosMsg}, this.consultarOperationCompleted, userState);
        }

        private void OnconsultarOperationCompleted(object arg)
        {
            if ((this.consultarCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.consultarCompleted(this, new consultarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if (((url == null)
                        || (url == string.Empty)))
            {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024)
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0)))
            {
                return true;
            }
            return false;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1064.2")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.gnre.pe.gov.br/webservice/GnreConfigUF")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.gnre.pe.gov.br/webservice/GnreConfigUF", IsNullable = false)]
    public partial class gnreCabecMsg : System.Web.Services.Protocols.SoapHeader
    {

        private string versaoDadosField;

        /// <remarks/>
        public string versaoDados
        {
            get
            {
                return this.versaoDadosField;
            }
            set
            {
                this.versaoDadosField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    public delegate void consultarCompletedEventHandler(object sender, consultarCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1038.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class consultarCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal consultarCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
            base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public System.Xml.XmlNode Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591