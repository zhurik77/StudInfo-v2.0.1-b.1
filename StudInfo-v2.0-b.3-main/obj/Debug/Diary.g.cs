﻿#pragma checksum "..\..\Diary.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F60D9A7DDE6782B0DDF84BB10285492AD76399486ACAC9A14491BE7EBFD06EC"
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
    /// Diary
    /// </summary>
    public partial class Diary : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Diary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid StudentDG;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Diary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid ThemeDG;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Diary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label textBoxStudent_FIO;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Diary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label textBox_GroupStudent;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Diary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Theme_Zone;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\Diary.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Opisanie_Zone;
        
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
            System.Uri resourceLocater = new System.Uri("/StudInfo v2.0 b.3;component/diary.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Diary.xaml"
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
            this.StudentDG = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\Diary.xaml"
            this.StudentDG.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.StudentDG_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ThemeDG = ((System.Windows.Controls.DataGrid)(target));
            
            #line 12 "..\..\Diary.xaml"
            this.ThemeDG.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ThemeDG_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.textBoxStudent_FIO = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.textBox_GroupStudent = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.Theme_Zone = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.Opisanie_Zone = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

