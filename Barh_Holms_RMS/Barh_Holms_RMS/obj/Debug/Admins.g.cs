#pragma checksum "..\..\Admins.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "763610A4B104398DF34FF1335938A9D181E4AC541C0E7062C2087FA1F4CD0C8C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Barh_Holms_RMS;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Barh_Holms_RMS {
    
    
    /// <summary>
    /// Admins
    /// </summary>
    public partial class Admins : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\Admins.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Foto;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Admins.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Surname;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\Admins.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Name;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Admins.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Post;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Admins.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button But_Form_Otch;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\Admins.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button But_Hustory_Vhod;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\Admins.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button But_Rash_Mat;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Barh_Holms_RMS;component/admins.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Admins.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Foto = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.Surname = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Name = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.Post = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.But_Form_Otch = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\Admins.xaml"
            this.But_Form_Otch.Click += new System.Windows.RoutedEventHandler(this.But_Click_Form_Otch);
            
            #line default
            #line hidden
            return;
            case 6:
            this.But_Hustory_Vhod = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\Admins.xaml"
            this.But_Hustory_Vhod.Click += new System.Windows.RoutedEventHandler(this.But_Click_Hustory_Vhod);
            
            #line default
            #line hidden
            return;
            case 7:
            this.But_Rash_Mat = ((System.Windows.Controls.Button)(target));
            
            #line 31 "..\..\Admins.xaml"
            this.But_Rash_Mat.Click += new System.Windows.RoutedEventHandler(this.But_Click_Rash_Mat);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

