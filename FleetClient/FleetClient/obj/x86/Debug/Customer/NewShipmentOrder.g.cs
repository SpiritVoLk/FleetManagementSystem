﻿#pragma checksum "C:\Users\Red\source\repos\FleetClient\FleetClient\Customer\NewShipmentOrder.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "ABA26D5E3F7ADFAD578E0179648D5010"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FleetClient
{
    partial class NewShipmentOrder : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // Customer\NewShipmentOrder.xaml line 16
                {
                    this.shipmentlist = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.shipmentlist).SelectionChanged += this.shipmentlist_SelectionChanged;
                }
                break;
            case 3: // Customer\NewShipmentOrder.xaml line 29
                {
                    this.brokersearch = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.brokersearch).TextChanged += this.brokersearch_TextChanged;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.brokersearch).QuerySubmitted += this.brokersearch_QuerySubmitted;
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)this.brokersearch).SuggestionChosen += this.brokersearch_SuggestionChosen;
                }
                break;
            case 4: // Customer\NewShipmentOrder.xaml line 45
                {
                    this.Save = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Save).Click += this.Save_Click;
                }
                break;
            case 5: // Customer\NewShipmentOrder.xaml line 46
                {
                    this.success = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.17.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
