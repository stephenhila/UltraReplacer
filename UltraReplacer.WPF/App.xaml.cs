using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using UltraReplacer.Logging;

namespace UltraReplacer.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            try
            {
                LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType).LogException(e.Exception, e.Exception.Message);
                e.Handled = true;
            }
            catch
            {
                e.Handled = false;
                throw;
            }
        }
    }
}
