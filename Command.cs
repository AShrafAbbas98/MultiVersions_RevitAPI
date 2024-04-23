using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Windows;

namespace MultiVersions_RevitAPI
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {

            string revitVeriosn = null;

#if Revit_2022
            revitVeriosn = "2022";
#endif

#if Revit_2024
            revitVeriosn = "2024";
#endif

            MessageBox.Show($"This line of code is for Revit {revitVeriosn}",
                "Multi-Version",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
          
            return Result.Succeeded;
        }
    }
}
