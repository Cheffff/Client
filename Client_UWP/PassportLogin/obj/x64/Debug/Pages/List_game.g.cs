﻿#pragma checksum "C:\Users\Nabil\Desktop\v1\PassportLogin\Pages\List_game.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "60C8C2E354550E6D09D2809209D13672"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PassportLogin.Pages
{
    partial class List_game : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1: // Pages\List_game.xaml line 12
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2: // Pages\List_game.xaml line 86
                {
                    this.txtAutoSuggestBox = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.txtAutoSuggestBox).TextChanged += this.AutoSuggestBox_TextChanged;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.txtAutoSuggestBox).SuggestionChosen += this.AutoSuggestBox_SuggestionChosen;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.txtAutoSuggestBox).QuerySubmitted += this.AutoSuggestBox_QuerySubmitted;
                }
                break;
            case 3: // Pages\List_game.xaml line 16
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                }
                break;
            case 4: // Pages\List_game.xaml line 42
                {
                    this.MenuButton5 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5: // Pages\List_game.xaml line 36
                {
                    this.MenuButton4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 6: // Pages\List_game.xaml line 30
                {
                    this.MenuButton3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 7: // Pages\List_game.xaml line 25
                {
                    this.MenuButton2 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.MenuButton2).Click += this.MenuButton2_Click;
                }
                break;
            case 8: // Pages\List_game.xaml line 20
                {
                    this.MenuButton1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.MenuButton1).Click += this.MenuButton1_Click;
                }
                break;
            case 9: // Pages\List_game.xaml line 53
                {
                    this.StudentsList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 10: // Pages\List_game.xaml line 68
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Button_Click21;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.16.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

