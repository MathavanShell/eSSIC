//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace eMosWF {
    
    
    [System.Runtime.InteropServices.ComVisible(false)]
    public partial class MosWF : System.Activities.Activity, System.ComponentModel.ISupportInitialize {
        
        private bool _contentLoaded;
        
        private System.Activities.InArgument<int> _curMode;
        
        private System.Activities.OutArgument<int> _nextState;
        
        private System.Activities.OutArgument<int> _nextFunction;
        
        private System.Activities.OutArgument<bool> _isEditMode;
        
        private System.Activities.OutArgument<int> _nextRole;
        
        private System.Activities.InArgument<int> _curRole;
        
        private System.Activities.InArgument<int> _extCount;
        
        private System.Activities.InArgument<int> _curState;
        
        private System.Activities.OutArgument<bool> _isNeedAction;
        
        private System.Activities.OutArgument<int> _nextCount;
        
partial void BeforeInitializeComponent(ref bool isInitialized);

partial void AfterInitializeComponent();

        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        public MosWF() {
            this.InitializeComponent();
        }
        
        public System.Activities.InArgument<int> curMode {
            get {
                return this._curMode;
            }
            set {
                this._curMode = value;
            }
        }
        
        public System.Activities.OutArgument<int> nextState {
            get {
                return this._nextState;
            }
            set {
                this._nextState = value;
            }
        }
        
        public System.Activities.OutArgument<int> nextFunction {
            get {
                return this._nextFunction;
            }
            set {
                this._nextFunction = value;
            }
        }
        
        public System.Activities.OutArgument<bool> isEditMode {
            get {
                return this._isEditMode;
            }
            set {
                this._isEditMode = value;
            }
        }
        
        public System.Activities.OutArgument<int> nextRole {
            get {
                return this._nextRole;
            }
            set {
                this._nextRole = value;
            }
        }
        
        public System.Activities.InArgument<int> curRole {
            get {
                return this._curRole;
            }
            set {
                this._curRole = value;
            }
        }
        
        public System.Activities.InArgument<int> extCount {
            get {
                return this._extCount;
            }
            set {
                this._extCount = value;
            }
        }
        
        public System.Activities.InArgument<int> curState {
            get {
                return this._curState;
            }
            set {
                this._curState = value;
            }
        }
        
        public System.Activities.OutArgument<bool> isNeedAction {
            get {
                return this._isNeedAction;
            }
            set {
                this._isNeedAction = value;
            }
        }
        
        public System.Activities.OutArgument<int> nextCount {
            get {
                return this._nextCount;
            }
            set {
                this._nextCount = value;
            }
        }
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        public void InitializeComponent() {
            if ((this._contentLoaded == true)) {
                return;
            }
            this._contentLoaded = true;
            bool isInitialized = false;
            this.BeforeInitializeComponent(ref isInitialized);
            if ((isInitialized == true)) {
                this.AfterInitializeComponent();
                return;
            }
            string resourceName = this.FindResource();
            System.IO.Stream initializeXaml = typeof(MosWF).Assembly.GetManifestResourceStream(resourceName);
            System.Xml.XmlReader xmlReader = null;
            System.Xaml.XamlReader reader = null;
            System.Xaml.XamlObjectWriter objectWriter = null;
            try {
                System.Xaml.XamlSchemaContext schemaContext = XamlStaticHelperNamespace._XamlStaticHelper.SchemaContext;
                xmlReader = System.Xml.XmlReader.Create(initializeXaml);
                System.Xaml.XamlXmlReaderSettings readerSettings = new System.Xaml.XamlXmlReaderSettings();
                readerSettings.LocalAssembly = System.Reflection.Assembly.GetExecutingAssembly();
                readerSettings.AllowProtectedMembersOnRoot = true;
                reader = new System.Xaml.XamlXmlReader(xmlReader, schemaContext, readerSettings);
                System.Xaml.XamlObjectWriterSettings writerSettings = new System.Xaml.XamlObjectWriterSettings();
                writerSettings.RootObjectInstance = this;
                writerSettings.AccessLevel = System.Xaml.Permissions.XamlAccessLevel.PrivateAccessTo(typeof(MosWF));
                objectWriter = new System.Xaml.XamlObjectWriter(schemaContext, writerSettings);
                System.Xaml.XamlServices.Transform(reader, objectWriter);
            }
            finally {
                if ((xmlReader != null)) {
                    ((System.IDisposable)(xmlReader)).Dispose();
                }
                if ((reader != null)) {
                    ((System.IDisposable)(reader)).Dispose();
                }
                if ((objectWriter != null)) {
                    ((System.IDisposable)(objectWriter)).Dispose();
                }
            }
            this.AfterInitializeComponent();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        private string FindResource() {
            string[] resources = typeof(MosWF).Assembly.GetManifestResourceNames();
            for (int i = 0; (i < resources.Length); i = (i + 1)) {
                string resource = resources[i];
                if ((resource.Contains(".MosWF.g.xaml") || resource.Equals("MosWF.g.xaml"))) {
                    return resource;
                }
            }
            throw new System.InvalidOperationException("Resource not found.");
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        void System.ComponentModel.ISupportInitialize.BeginInit() {
        }
        
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033")]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("XamlBuildTask", "16.0.0.0")]
        void System.ComponentModel.ISupportInitialize.EndInit() {
            this.InitializeComponent();
        }
    }
}
