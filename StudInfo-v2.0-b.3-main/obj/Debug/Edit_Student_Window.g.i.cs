﻿#pragma checksum "..\..\Edit_Student_Window.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D96B2C62D4CBA64CBC27CC2A682489C260FD61C63C433C612BE636C9EF52969F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using StudInfo_v2._0_b._3;
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


namespace StudInfo_v2._0_b._3 {
    
    
    /// <summary>
    /// Edit_Student_Window
    /// </summary>
    public partial class Edit_Student_Window : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\Edit_Student_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridStudents;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Edit_Student_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FIO_Student;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Edit_Student_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Group_Student;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Edit_Student_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker Date_Student;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Edit_Student_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Save_Student;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Edit_Student_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cancel;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Edit_Student_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Delete_Student;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\Edit_Student_Window.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_Student;
        
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
            System.Uri resourceLocater = new System.Uri("/StudInfo v2.0 b.3;component/edit_student_window.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Edit_Student_Window.xaml"
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
            this.gridStudents = ((System.Windows.Controls.DataGrid)(target));
            
            #line 14 "..\..\Edit_Student_Window.xaml"
            this.gridStudents.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.gridStudents_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.FIO_Student = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Group_Student = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Date_Student = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.Save_Student = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\Edit_Student_Window.xaml"
            this.Save_Student.Click += new System.Windows.RoutedEventHandler(this.Save_Student_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Cancel = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\Edit_Student_Window.xaml"
            this.Cancel.Click += new System.Windows.RoutedEventHandler(this.Cancel_Adding);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Delete_Student = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\Edit_Student_Window.xaml"
            this.Delete_Student.Click += new System.Windows.RoutedEventHandler(this.Delete_Student_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Add_Student = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\Edit_Student_Window.xaml"
            this.Add_Student.Click += new System.Windows.RoutedEventHandler(this.Add_Student_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

