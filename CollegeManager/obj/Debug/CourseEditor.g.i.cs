﻿#pragma checksum "..\..\CourseEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2E6E3DDDCA0E6AD2ACAEB5CDB74992671EF3C284011EB209811785F83756ED82"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CollegeManager;
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


namespace CollegeManager {
    
    
    /// <summary>
    /// CourseEditor
    /// </summary>
    public partial class CourseEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 48 "..\..\CourseEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameTB;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\CourseEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox LocatonTB;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\CourseEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker StartDateDP;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\CourseEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker EndDateDP;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\CourseEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TargetHoursTB;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\CourseEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PassedHoursTB;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\CourseEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Move;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\CourseEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\CourseEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddTheme;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\CourseEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ThemesLB;
        
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
            System.Uri resourceLocater = new System.Uri("/CollegeManager;component/courseeditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CourseEditor.xaml"
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
            this.NameTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.LocatonTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.StartDateDP = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.EndDateDP = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.TargetHoursTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.PassedHoursTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Move = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\CourseEditor.xaml"
            this.Move.Click += new System.Windows.RoutedEventHandler(this.Move_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\CourseEditor.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.AddTheme = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\CourseEditor.xaml"
            this.AddTheme.Click += new System.Windows.RoutedEventHandler(this.AddTheme_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.ThemesLB = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 11:
            
            #line 101 "..\..\CourseEditor.xaml"
            ((System.Windows.Controls.ComboBox)(target)).SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TeachersTB_SelectionChanged);
            
            #line default
            #line hidden
            break;
            case 12:
            
            #line 102 "..\..\CourseEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditTheme_Click);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}
