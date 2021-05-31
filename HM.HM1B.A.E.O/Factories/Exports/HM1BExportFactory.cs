namespace HM.HM1B.A.E.O.Factories.Exports
{
    using System;

    using log4net;

    using HM.HM1B.A.E.O.Classes.Exports;
    using HM.HM1B.A.E.O.Interfaces.Exports;
    using HM.HM1B.A.E.O.InterfacesFactories.Exports;

    internal sealed class HM1BExportFactory : IHM1BExportFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public HM1BExportFactory()
        {
        }

        public IHM1BExport Create()
        {
            IHM1BExport export = null;

            try
            {
                export = new HM1BExport();
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return export;
        }
    }
}