﻿using System.Web.Hosting;
using Merchello.Core;

namespace Merchello.Examine.DataServices
{
    public class MerchelloDataService : IDataService
    {
        public MerchelloDataService()
            : this(MerchelloContext.Current)
        {}

        public MerchelloDataService(IMerchelloContext merchelloContext)
        {
            ProductDataService = new ProductDataService(merchelloContext);
            InvoiceDataService = new InvoiceDataService(merchelloContext);
            OrderDataService = new OrderDataService(merchelloContext);

            LogService = new MerchelloLogService();
        }

        public IProductDataService ProductDataService { get; private set; }
        public IInvoiceDataService InvoiceDataService { get; private set; }
        public IOrderDataService OrderDataService { get; private set; }

        public ILogService LogService { get; private set; }

        public string MapPath(string virtualPath)
        {
            return HostingEnvironment.MapPath(virtualPath);
        }
    }
}