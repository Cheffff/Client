﻿#pragma checksum "C:\Users\Nabil\Desktop\v1\PassportLogin\Pages\DL_chess.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "783E508651C554AE41359C98E4D1730F"
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
    partial class DL_chess : 
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
            case 1: // Pages\DL_chess.xaml line 11
                {
                    this.btnDownload = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDownload).Click += this.btnDownload_Click;
                }
                break;
            case 2: // Pages\DL_chess.xaml line 13
                {
                    this.btnPauseResume = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPauseResume).Click += this.btnPauseResume_Click;
                }
                break;
            case 3: // Pages\DL_chess.xaml line 15
                {
                    this.btnCancel = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnCancel).Click += this.btnCancel_Click;
                }
                break;
            case 4: // Pages\DL_chess.xaml line 17
                {
                    this.ProgressBarDownload = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 5: // Pages\DL_chess.xaml line 18
                {
                    this.txtProgress = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6: // Pages\DL_chess.xaml line 19
                {
                    this.txtStatus = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // Pages\DL_chess.xaml line 20
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.button_Click;
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

